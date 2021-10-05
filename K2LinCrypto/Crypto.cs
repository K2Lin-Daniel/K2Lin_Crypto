using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace K2LinCrypto
{
    public partial class Crypto : Form
    {
        int dwKeySize = 2048;
        public Crypto()
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(dwKeySize);
            csp.PersistKeyInCsp = false;
            InitializeComponent();
            string publickey = csp.ToXmlString(false);
            string privatekey = csp.ToXmlString(true);
            XmlDocument PublicKeyXML = new XmlDocument();
            PublicKeyXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
            XmlElement PubText = PublicKeyXML.CreateElement("PublicKey");
            PubText.InnerText = publickey;
            PublicKeyXML.DocumentElement.AppendChild(PubText);
            pubkey.Text = PublicKeyXML.OuterXml;
            XmlDocument PrivateKeyXML = new XmlDocument();
            PrivateKeyXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
            XmlElement PrivText = PrivateKeyXML.CreateElement("PrivateKey");
            PrivText.InnerText = privatekey;
            PrivateKeyXML.DocumentElement.AppendChild(PrivText);
            privkey.Text = PrivateKeyXML.OuterXml;
            SelfSessionID.Text = Math.Abs(pubkey.Text.GetHashCode()).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void generate_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(dwKeySize);
            csp.PersistKeyInCsp = false;
            pubkey.Text = csp.ToXmlString(false);
            privkey.Text = csp.ToXmlString(true);
            SelfSessionID.Text = Math.Abs(pubkey.Text.GetHashCode()).ToString();
        }
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            XmlDocument PublicKeyXML = new XmlDocument();
            PublicKeyXML.LoadXml(ReceiverPublic.Text);
            string pubkeypath = "K2LinCrypto/PublicKey";
            string ReceiverPubkey = PublicKeyXML.SelectSingleNode(pubkeypath).InnerText;
            rsa.FromXmlString(ReceiverPubkey);
            byte[] data = Encoding.UTF8.GetBytes(EncryptoText.Text);
            byte[] encryptedtext = rsa.Encrypt(data, false);
            XmlDocument EncryptXML = new XmlDocument();
            EncryptXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
            XmlElement Text = EncryptXML.CreateElement("EncryptedText");
            Text.InnerText = Convert.ToBase64String(encryptedtext);
            EncryptXML.DocumentElement.AppendChild(Text);
            XmlElement HashID = EncryptXML.CreateElement("HashID");
            HashID.InnerText = EncryptSessionID.Text;
            EncryptXML.DocumentElement.AppendChild(HashID);
            EncryptoResult.Text = EncryptXML.OuterXml;
        }
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            XmlDocument DecryptXML = new XmlDocument();
            DecryptXML.LoadXml(DecryptoText.Text);
            string textpath = "K2LinCrypto/EncryptedText";
            string DecryptText = DecryptXML.SelectSingleNode(textpath).InnerText;
            string hashpath = "K2LinCrypto/HashID";
            string HashID = DecryptXML.SelectSingleNode(hashpath).InnerText;
            if (HashID != SelfSessionID.Text)
            {
                HashIDIncorrect.Visible = true;
                return;
            }
            else
            {
                HashIDIncorrect.Visible = false;
            }
            XmlDocument PrivateKeyXML = new XmlDocument();
            PrivateKeyXML.LoadXml(privkey.Text);
            string privkeypath = "K2LinCrypto/PrivateKey";
            string Privkey = PrivateKeyXML.SelectSingleNode(privkeypath).InnerText;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(Privkey);
            byte[] Encryptedtext = Convert.FromBase64String(DecryptText);
            byte[] decryptedtext = rsa.Decrypt(Encryptedtext, false);
            DecryptoResult.Text = Encoding.UTF8.GetString(decryptedtext);
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void CopyPublicKey_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)pubkey.Text);
        }
        private void ReceiverPublic_TextChanged(object sender, EventArgs e)
        {
            EncryptSessionID.Text = Math.Abs(ReceiverPublic.Text.GetHashCode()).ToString();
        }
        private void Sel2048_CheckedChanged(object sender, EventArgs e)
        {
            dwKeySize = 2048;
        }
        private void Sel4096_CheckedChanged(object sender, EventArgs e)
        {
            dwKeySize = 4096;
        }
        private void Sel8192_CheckedChanged(object sender, EventArgs e)
        {
            dwKeySize = 8192;
        }

        private void CopyEncryptedText_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)EncryptoResult.Text);
        }

        private void SwapMode_CheckedChanged(object sender, EventArgs e)
        {
            if (SwapMode.Checked)
            {
                // Do something when CheckBox is checked  
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                DecryptionText.Visible = true;
                EncryptionText.Visible = false;
                label8.Visible = true;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label9.Visible = true;
                CopyEncryptedText.Visible = false;
                label11.Visible = false;
                EncryptSessionID.Visible = false;
                EncryptButton.Visible = false;
                DecryptButton.Visible = true;
                DecryptoResult.Visible = true;
                ReceiverPublic.Visible = false;
                EncryptoResult.Visible = false;
                EncryptoText.Visible = false;
                DecryptoText.Visible = true;
                HashIDIncorrect.Visible = false;
            }
            else
            {
                // Do something here when CheckBox is not checked  
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                DecryptionText.Visible = false;
                EncryptionText.Visible = true;
                label8.Visible = false;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label9.Visible = false;
                CopyEncryptedText.Visible = true;
                label11.Visible = true;
                EncryptSessionID.Visible = true;
                EncryptButton.Visible = true;
                DecryptButton.Visible = false;
                DecryptoResult.Visible = false;
                ReceiverPublic.Visible = true;
                EncryptoResult.Visible = true;
                EncryptoText.Visible = true;
                DecryptoText.Visible = false;
                HashIDIncorrect.Visible = false;
            }
        }
    }
}
