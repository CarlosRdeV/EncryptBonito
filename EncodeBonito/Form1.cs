using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncodeBonito
{
    public partial class frmMain : Form
    {
        string txtPassword = "abc";

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnDecrypt.Height;
           pnlOnButtonPosition.Top = btnDecrypt.Top;
            pnlDecrypt1.Visible = true;
            pnlEncrypt.Visible = false;
            pnlPassword.Visible = false;


        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            pnlOnButtonPosition.Height = btnPassword.Height;
            pnlOnButtonPosition.Top = btnPassword.Top;
            pnlPassword.Visible = true;
            pnlEncrypt.Visible = false;
            pnlDecrypt1.Visible = false;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
           pnlOnButtonPosition.Height = btnEncrypt.Height;
           pnlOnButtonPosition.Top = btnEncrypt.Top;
            pnlEncrypt.Visible = true;
            pnlDecrypt1.Visible = false;
            pnlPassword.Visible = false;


        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMax_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnCopyAll_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEncryptOutput.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDecryptOutput.Text);
        }

        private void btnEncryptAction_Click(object sender, EventArgs e)
        {
            txtEncryptOutput.Text = Cifrador.Encrypt(txtEncryptInput.Text, txtPassword);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDecryptOutput.Text = Cifrador.Decrypt(txtDecryptInput.Text, txtPassword);

        }
    }
}
