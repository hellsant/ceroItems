namespace ChuwiGoHome
{
    partial class LoginF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginF));
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.user_key_log = new System.Windows.Forms.PictureBox();
            this.user_login = new System.Windows.Forms.PictureBox();
            this.cerrar_Lo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iniciar_sesion = new System.Windows.Forms.Button();
            this.registrar_log = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user_key_log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_user
            // 
            this.textBox_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_user.Location = new System.Drawing.Point(92, 164);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(165, 22);
            this.textBox_user.TabIndex = 4;
            this.textBox_user.Text = "user";
            // 
            // textBox_key
            // 
            this.textBox_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox_key.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_key.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_key.Location = new System.Drawing.Point(91, 216);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(166, 22);
            this.textBox_key.TabIndex = 5;
            this.textBox_key.Text = "contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(57, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(57, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Si no tiene cuenta puedes registrarse aqui!!!";
            // 
            // user_key_log
            // 
            this.user_key_log.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_key_log.BackgroundImage")));
            this.user_key_log.Location = new System.Drawing.Point(56, 211);
            this.user_key_log.Name = "user_key_log";
            this.user_key_log.Size = new System.Drawing.Size(30, 32);
            this.user_key_log.TabIndex = 3;
            this.user_key_log.TabStop = false;
            // 
            // user_login
            // 
            this.user_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("user_login.BackgroundImage")));
            this.user_login.Location = new System.Drawing.Point(55, 155);
            this.user_login.Name = "user_login";
            this.user_login.Size = new System.Drawing.Size(33, 36);
            this.user_login.TabIndex = 2;
            this.user_login.TabStop = false;
            // 
            // cerrar_Lo
            // 
            this.cerrar_Lo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cerrar_Lo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrar_Lo.BackgroundImage")));
            this.cerrar_Lo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cerrar_Lo.ForeColor = System.Drawing.Color.White;
            this.cerrar_Lo.Location = new System.Drawing.Point(275, 4);
            this.cerrar_Lo.Name = "cerrar_Lo";
            this.cerrar_Lo.Size = new System.Drawing.Size(32, 32);
            this.cerrar_Lo.TabIndex = 1;
            this.cerrar_Lo.UseVisualStyleBackColor = false;
            this.cerrar_Lo.Click += new System.EventHandler(this.cerrar_Lo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 69);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iniciar_sesion
            // 
            this.iniciar_sesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iniciar_sesion.BackgroundImage")));
            this.iniciar_sesion.FlatAppearance.BorderSize = 0;
            this.iniciar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iniciar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar_sesion.ForeColor = System.Drawing.Color.Transparent;
            this.iniciar_sesion.Location = new System.Drawing.Point(79, 250);
            this.iniciar_sesion.Name = "iniciar_sesion";
            this.iniciar_sesion.Size = new System.Drawing.Size(152, 64);
            this.iniciar_sesion.TabIndex = 12;
            this.iniciar_sesion.Text = "Iniciar session";
            this.iniciar_sesion.UseVisualStyleBackColor = true;
            this.iniciar_sesion.Click += new System.EventHandler(this.iniciar_sesion_Click);
            // 
            // registrar_log
            // 
            this.registrar_log.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registrar_log.BackgroundImage")));
            this.registrar_log.FlatAppearance.BorderSize = 0;
            this.registrar_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrar_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrar_log.ForeColor = System.Drawing.Color.Transparent;
            this.registrar_log.Location = new System.Drawing.Point(79, 337);
            this.registrar_log.Name = "registrar_log";
            this.registrar_log.Size = new System.Drawing.Size(152, 64);
            this.registrar_log.TabIndex = 13;
            this.registrar_log.Text = "Registrar";
            this.registrar_log.UseVisualStyleBackColor = true;
            this.registrar_log.Click += new System.EventHandler(this.registrar_log_Click);
            // 
            // LoginF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(311, 407);
            this.Controls.Add(this.registrar_log);
            this.Controls.Add(this.iniciar_sesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_key);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.user_key_log);
            this.Controls.Add(this.user_login);
            this.Controls.Add(this.cerrar_Lo);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginF";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.user_key_log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cerrar_Lo;
        private System.Windows.Forms.PictureBox user_login;
        private System.Windows.Forms.PictureBox user_key_log;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button iniciar_sesion;
        private System.Windows.Forms.Button registrar_log;
    }
}