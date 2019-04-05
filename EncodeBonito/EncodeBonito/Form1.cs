using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            btnEncrypt.Enabled = false;
            btnDecrypt.Enabled = false;
            btnPassword.Enabled = false;
            btnLogout.Enabled = false;
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
           
        }

        private void picMin_Click(object sender, EventArgs e)
        {
           
        }

        private void picMax_Click(object sender, EventArgs e)
        {
           
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
            if (txtEncryptInput.Text=="")
            {
                MessageBox.Show("Inserta una cadena de texto, no puedes dejarlo en blanco");
            }
            else
            {
                txtEncryptOutput.Text = Cifrador.Encrypt(txtEncryptInput.Text, txtPassword);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (txtDecryptInput.Text == "")
                {
                    MessageBox.Show("Inserta una cadena encriptada, no puedes dejarlo en blanco");
                }
                else
                {
                    txtDecryptOutput.Text = Cifrador.Decrypt(txtDecryptInput.Text, txtPassword);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("La cadena no es valida");
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show("ALERTA, la cadena ingresada ha sido modificada o insertó una contraseña invalida");
            }

        }

        private void picMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picMax_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void picClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "admin")
            {
                btnEncrypt.Enabled = true;
                btnDecrypt.Enabled = true;
                btnPassword.Enabled = true;
                btnLogout.Enabled = true;
                btnLogin.Enabled = false;
                pnlLogin.Visible = false;
                pnlEncrypt.Visible = true;
                txtUser.Text = "";
                txtPass.Text = "";


            }
            else if(txtUser.Text=="user" & txtPass.Text=="user")
            {
                btnEncrypt.Enabled = true;
                btnDecrypt.Enabled = true;
                btnPassword.Enabled = false;
                btnLogout.Enabled = true;
                btnLogin.Enabled = false;
                pnlLogin.Visible = false;
                pnlEncrypt.Visible = true;
                txtUser.Text = "";
                txtPass.Text = "";
            }
            else
            {
                MessageBox.Show("Combinación Invalida");
                txtUser.Text = "";
                txtPass.Text = "";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnEncrypt.Enabled = false;
            btnDecrypt.Enabled = false;
            btnPassword.Enabled = false;
            btnLogout.Enabled = false;
            btnLogin.Enabled = true;
            pnlLogin.Visible = true;
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            if(InputPassword.Text=="" & InputPasswordConfirm.Text=="")
            {
                MessageBox.Show("Inserte una contraseña y su confirmación");
            }
            else if(InputPassword.Text != InputPasswordConfirm.Text)
            {
                MessageBox.Show("Las contraseñas deben contener el mismo valor, intente de nuevo");
            }
            else if(InputPassword.Text == InputPasswordConfirm.Text)
            {
                txtPassword = InputPassword.Text;
                MessageBox.Show("La contraseña ha sido guardada");
            }
        }

        private void InputPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
