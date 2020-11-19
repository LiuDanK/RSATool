using System;
using System.Windows.Forms;

namespace RSA注册机
{
    public partial class FrmMain : MetroSet_UI.Forms.MetroSetForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private RsaKey rsaKey = new RsaKey();

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPrivateKey.DataBindings.Add("Text", rsaKey, "PrivateKey");
            txtPublicKey.DataBindings.Add("Text", rsaKey, "PublicKey");
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            txtAuthCode.Text = Rsa2Helper.CreateUseCode(txtMchineCode.Text, rsaKey.PrivateKey);
        }

        private void BtnDeCode_Click(object sender, EventArgs e)
        {
            txtMchineCode2.Text = Rsa2Helper.DecryptByPublicKey(txtAuthCode.Text, rsaKey.PublicKey);
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtMchineCode.Text.Equals(txtMchineCode2.Text).ToString());
        }

        private void BtnCopyAuthCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtAuthCode.Text);
        }

        private void BtnCopyPublicKey_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPublicKey.Text);
        }

        private void BtnCopyPrivateKey_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPrivateKey.Text);
        }

        /// <summary>
        /// 生成一对新密钥
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Rsa2Helper.GenerateSecretKey(out var publicKey, out var privateKey);
            txtPublicKey.Text = rsaKey.PublicKey = publicKey;
            txtPrivateKey.Text = rsaKey.PrivateKey = privateKey;
        }

        public class RsaKey
        {
            public string PublicKey { get; set; }
            public string PrivateKey { get; set; }
        }

        private void txtPublicKey_TextChanged(object sender, EventArgs e)
        {
            rsaKey.PublicKey = txtPublicKey.Text;
        }

        private void txtPrivateKey_TextChanged(object sender, EventArgs e)
        {
            rsaKey.PrivateKey = txtPrivateKey.Text;
        }
    }
}