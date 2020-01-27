namespace ChuwiGoHome
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.listView1_ped = new System.Windows.Forms.ListView();
            this.listView2_prod = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.det_cerrar = new System.Windows.Forms.PictureBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.det_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1_ped
            // 
            this.listView1_ped.Location = new System.Drawing.Point(5, 42);
            this.listView1_ped.Name = "listView1_ped";
            this.listView1_ped.Size = new System.Drawing.Size(400, 540);
            this.listView1_ped.TabIndex = 22;
            this.listView1_ped.UseCompatibleStateImageBehavior = false;
            this.listView1_ped.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_ped_MouseClick);
            // 
            // listView2_prod
            // 
            this.listView2_prod.Location = new System.Drawing.Point(408, 42);
            this.listView2_prod.Name = "listView2_prod";
            this.listView2_prod.Size = new System.Drawing.Size(400, 540);
            this.listView2_prod.TabIndex = 23;
            this.listView2_prod.UseCompatibleStateImageBehavior = false;
            this.listView2_prod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_prod_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.det_cerrar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 37);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(330, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar pedidos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // det_cerrar
            // 
            this.det_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.det_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.det_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("det_cerrar.BackgroundImage")));
            this.det_cerrar.Location = new System.Drawing.Point(782, 1);
            this.det_cerrar.Name = "det_cerrar";
            this.det_cerrar.Size = new System.Drawing.Size(30, 29);
            this.det_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.det_cerrar.TabIndex = 0;
            this.det_cerrar.TabStop = false;
            this.det_cerrar.Click += new System.EventHandler(this.det_cerrar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.Cancelar.FlatAppearance.BorderSize = 0;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar.Location = new System.Drawing.Point(5, 588);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(113, 40);
            this.Cancelar.TabIndex = 26;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // guardar
            // 
            this.guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guardar.BackColor = System.Drawing.Color.Transparent;
            this.guardar.FlatAppearance.BorderSize = 0;
            this.guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.Color.DarkGreen;
            this.guardar.Image = ((System.Drawing.Image)(resources.GetObject("guardar.Image")));
            this.guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guardar.Location = new System.Drawing.Point(696, 588);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(103, 40);
            this.guardar.TabIndex = 25;
            this.guardar.Text = "Guardar";
            this.guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardar.UseVisualStyleBackColor = false;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(815, 645);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView2_prod);
            this.Controls.Add(this.listView1_ped);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.det_cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1_ped;
        private System.Windows.Forms.ListView listView2_prod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox det_cerrar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button guardar;
    }
}