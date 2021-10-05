using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

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
            pubkey.Text = csp.ToXmlString(false);
            privkey.Text = csp.ToXmlString(true);
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
            rsa.FromXmlString(ReceiverPublic.Text);
            byte[] data = Encoding.UTF8.GetBytes(EncryptoText.Text);
            byte[] encryptedtext = rsa.Encrypt(data, false);
            EncryptoResult.Text = Convert.ToBase64String(encryptedtext);
        }
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(privkey.Text);
            byte[] Encryptedtext = Convert.FromBase64String(DecryptoText.Text);
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
                label7.Visible = true;
                label3.Visible = false;
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
            }
            else
            {
                // Do something here when CheckBox is not checked  
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                label7.Visible = false;
                label3.Visible = true;
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
            }
        }
    }
}
