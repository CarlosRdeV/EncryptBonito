namespace EncodeBonito
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeftSide = new System.Windows.Forms.Panel();
            this.pnlOnButtonPosition = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMax = new System.Windows.Forms.PictureBox();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.pnlTopSide = new System.Windows.Forms.Panel();
            this.pnlEncrypt = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEncryptAction = new System.Windows.Forms.Button();
            this.btnCopyAll = new System.Windows.Forms.Button();
            this.txtEncryptOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEncryptInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDecrypt1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDecryptOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDecryptInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlLeftSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            this.pnlEncrypt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDecrypt1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftSide
            // 
            this.pnlLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pnlLeftSide.Controls.Add(this.pnlOnButtonPosition);
            this.pnlLeftSide.Controls.Add(this.picClose);
            this.pnlLeftSide.Controls.Add(this.picMax);
            this.pnlLeftSide.Controls.Add(this.picMin);
            this.pnlLeftSide.Controls.Add(this.label7);
            this.pnlLeftSide.Controls.Add(this.btnPassword);
            this.pnlLeftSide.Controls.Add(this.btnDecrypt);
            this.pnlLeftSide.Controls.Add(this.btnEncrypt);
            this.pnlLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSide.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftSide.Name = "pnlLeftSide";
            this.pnlLeftSide.Size = new System.Drawing.Size(200, 459);
            this.pnlLeftSide.TabIndex = 0;
            // 
            // pnlOnButtonPosition
            // 
            this.pnlOnButtonPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.pnlOnButtonPosition.Location = new System.Drawing.Point(0, 72);
            this.pnlOnButtonPosition.Name = "pnlOnButtonPosition";
            this.pnlOnButtonPosition.Size = new System.Drawing.Size(9, 39);
            this.pnlOnButtonPosition.TabIndex = 2;
            // 
            // picClose
            // 
            this.picClose.BackgroundImage = global::EncodeBonito.Properties.Resources.icons8_delete_24;
            this.picClose.Location = new System.Drawing.Point(12, 7);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.TabIndex = 8;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picMax
            // 
            this.picMax.BackgroundImage = global::EncodeBonito.Properties.Resources.icons8_maximize_window_24;
            this.picMax.Location = new System.Drawing.Point(72, 7);
            this.picMax.Name = "picMax";
            this.picMax.Size = new System.Drawing.Size(24, 24);
            this.picMax.TabIndex = 7;
            this.picMax.TabStop = false;
            this.picMax.Click += new System.EventHandler(this.picMax_Click);
            // 
            // picMin
            // 
            this.picMin.BackgroundImage = global::EncodeBonito.Properties.Resources.icons8_minimize_window_24;
            this.picMin.Location = new System.Drawing.Point(42, 7);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(24, 24);
            this.picMin.TabIndex = 6;
            this.picMin.TabStop = false;
            this.picMin.Click += new System.EventHandler(this.picMin_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(30, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "EncryptApp";
            // 
            // btnPassword
            // 
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnPassword.Image = global::EncodeBonito.Properties.Resources.icons8_key_32;
            this.btnPassword.Location = new System.Drawing.Point(0, 162);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(200, 39);
            this.btnPassword.TabIndex = 3;
            this.btnPassword.Text = "Password";
            this.btnPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnDecrypt.Image = global::EncodeBonito.Properties.Resources.icons8_padlock_32;
            this.btnDecrypt.Location = new System.Drawing.Point(0, 117);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(200, 39);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnEncrypt.Image = global::EncodeBonito.Properties.Resources.icons8_privacy_32;
            this.btnEncrypt.Location = new System.Drawing.Point(0, 72);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(200, 39);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // pnlTopSide
            // 
            this.pnlTopSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(181)))));
            this.pnlTopSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSide.Location = new System.Drawing.Point(200, 0);
            this.pnlTopSide.Name = "pnlTopSide";
            this.pnlTopSide.Size = new System.Drawing.Size(667, 34);
            this.pnlTopSide.TabIndex = 1;
            // 
            // pnlEncrypt
            // 
            this.pnlEncrypt.Controls.Add(this.panel1);
            this.pnlEncrypt.Location = new System.Drawing.Point(203, 36);
            this.pnlEncrypt.Name = "pnlEncrypt";
            this.pnlEncrypt.Size = new System.Drawing.Size(667, 423);
            this.pnlEncrypt.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.btnEncryptAction);
            this.panel1.Controls.Add(this.btnCopyAll);
            this.panel1.Controls.Add(this.txtEncryptOutput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEncryptInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(34, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 160);
            this.panel1.TabIndex = 0;
            // 
            // btnEncryptAction
            // 
            this.btnEncryptAction.BackgroundImage = global::EncodeBonito.Properties.Resources.icons8_password_321;
            this.btnEncryptAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEncryptAction.FlatAppearance.BorderSize = 0;
            this.btnEncryptAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptAction.Location = new System.Drawing.Point(122, 113);
            this.btnEncryptAction.Name = "btnEncryptAction";
            this.btnEncryptAction.Size = new System.Drawing.Size(35, 35);
            this.btnEncryptAction.TabIndex = 5;
            this.btnEncryptAction.UseVisualStyleBackColor = true;
            this.btnEncryptAction.Click += new System.EventHandler(this.btnEncryptAction_Click);
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.BackgroundImage = global::EncodeBonito.Properties.Resources.icons8_copy_32;
            this.btnCopyAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopyAll.FlatAppearance.BorderSize = 0;
            this.btnCopyAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyAll.Location = new System.Drawing.Point(445, 74);
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(25, 25);
            this.btnCopyAll.TabIndex = 4;
            this.btnCopyAll.UseVisualStyleBackColor = true;
            this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
            // 
            // txtEncryptOutput
            // 
            this.txtEncryptOutput.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptOutput.Location = new System.Drawing.Point(122, 74);
            this.txtEncryptOutput.Name = "txtEncryptOutput";
            this.txtEncryptOutput.Size = new System.Drawing.Size(317, 25);
            this.txtEncryptOutput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadena cifrada: ";
            // 
            // txtEncryptInput
            // 
            this.txtEncryptInput.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptInput.Location = new System.Drawing.Point(122, 22);
            this.txtEncryptInput.Name = "txtEncryptInput";
            this.txtEncryptInput.Size = new System.Drawing.Size(317, 25);
            this.txtEncryptInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserta cadena: ";
            // 
            // pnlDecrypt1
            // 
            this.pnlDecrypt1.Controls.Add(this.panel3);
            this.pnlDecrypt1.Location = new System.Drawing.Point(203, 36);
            this.pnlDecrypt1.Name = "pnlDecrypt1";
            this.pnlDecrypt1.Size = new System.Drawing.Size(667, 423);
            this.pnlDecrypt1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.txtDecryptOutput);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtDecryptInput);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(34, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 160);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::EncodeBonito.Properties.Resources.icons8_padlock_322;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(122, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::EncodeBonito.Properties.Resources.icons8_copy_32;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(445, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDecryptOutput
            // 
            this.txtDecryptOutput.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptOutput.Location = new System.Drawing.Point(122, 74);
            this.txtDecryptOutput.Name = "txtDecryptOutput";
            this.txtDecryptOutput.Size = new System.Drawing.Size(317, 25);
            this.txtDecryptOutput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cadena descifrada: ";
            // 
            // txtDecryptInput
            // 
            this.txtDecryptInput.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptInput.Location = new System.Drawing.Point(122, 22);
            this.txtDecryptInput.Name = "txtDecryptInput";
            this.txtDecryptInput.Size = new System.Drawing.Size(317, 25);
            this.txtDecryptInput.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Inserta cadena: ";
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.panel4);
            this.pnlPassword.Location = new System.Drawing.Point(203, 36);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(667, 423);
            this.pnlPassword.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(34, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 330);
            this.panel4.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::EncodeBonito.Properties.Resources.icons8_save_32;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(95, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(163, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 25);
            this.textBox3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cadena descifrada: ";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(163, 66);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(133, 25);
            this.textBox4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Inserta Password: ";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(499, 50);
            this.label8.TabIndex = 6;
            this.label8.Text = "Seleccione el Password con el que serán cifrados sus mensajes, posteriormente ing" +
    "rese la contraseña del administrador para validar el cambio.";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 459);
            this.Controls.Add(this.pnlDecrypt1);
            this.Controls.Add(this.pnlEncrypt);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlTopSide);
            this.Controls.Add(this.pnlLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlLeftSide.ResumeLayout(false);
            this.pnlLeftSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            this.pnlEncrypt.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDecrypt1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftSide;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Panel pnlTopSide;
        private System.Windows.Forms.Panel pnlOnButtonPosition;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Panel pnlDecrypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMax;
        private System.Windows.Forms.Panel pnlEncrypt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEncryptAction;
        private System.Windows.Forms.Button btnCopyAll;
        private System.Windows.Forms.TextBox txtEncryptOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEncryptInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDecrypt1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDecryptOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDecryptInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

