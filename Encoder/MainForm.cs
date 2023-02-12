using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encoder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void rdbRSADecrypt_CheckedChanged(object sender, EventArgs e)
        {
            this.btnRSAEncryptOrDecrypt.Text = this.rdbRSADecrypt.Text;
        }

        private void rdbRSAEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            this.btnRSAEncryptOrDecrypt.Text = this.rdbRSAEncrypt.Text;
        }





        private void btnRSAEncryptOrDecrypt_Click(object sender, EventArgs e)
        {
            /*
             * RSA 加密 & 解密
             */
            string sourceText = this.txtRSASourceText.Text;
            string key = this.txtRSAKey.Text;

            if (string.IsNullOrEmpty(sourceText))
            {
                MessageBox.Show("源文本不能为空。");
                return;
            }

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("密钥不能为空。");
                return;
            }

            string targetText = string.Empty;

            if (this.rdbRSAEncrypt.Checked)
            {
                /* RSA 加密 */
                try
                {
                    targetText = Encoder.RSAEncrypt(sourceText, key);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("解密失败！\r\nError:" + ex.Message);
                }
            }
            else
            {
                /* RSA 解密 */
                try
                {
                    targetText = Encoder.RSADecrypt(sourceText, key);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("解密失败！\r\nError:" + ex.Message);
                }
            }

            this.txtRSATargetText.Text = targetText;
        }

        private void btnCreateKeys_Click(object sender, EventArgs e)
        {
            CreateRSAKeysForm f = new CreateRSAKeysForm();
            f.ShowDialog();
        }

        private void txtRSAKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbpRSA_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/yang-zhibo/RSALAN");
        }
    }
}
