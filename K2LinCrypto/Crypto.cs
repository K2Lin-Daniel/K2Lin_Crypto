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
    }
}
