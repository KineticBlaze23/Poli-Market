namespace CapaPresentacion
{
    partial class FormLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbTiposDeIngreso = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnVerContraseña = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo5;
            this.pictureBox1.InitialImage = global::CapaPresentacion.Properties.Resources.Logo2_50_;
            this.pictureBox1.Location = new System.Drawing.Point(56, 134);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // cmbTiposDeIngreso
            // 
            this.cmbTiposDeIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiposDeIngreso.FormattingEnabled = true;
            this.cmbTiposDeIngreso.Location = new System.Drawing.Point(57, 86);
            this.cmbTiposDeIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTiposDeIngreso.Name = "cmbTiposDeIngreso";
            this.cmbTiposDeIngreso.Size = new System.Drawing.Size(120, 24);
            this.cmbTiposDeIngreso.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblUsuario.Location = new System.Drawing.Point(19, 125);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblContraseña.Location = new System.Drawing.Point(20, 203);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(79, 16);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtUsuario.Location = new System.Drawing.Point(24, 155);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(153, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSize = true;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnIngresar.Location = new System.Drawing.Point(23, 262);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(101, 32);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtContraseña.Location = new System.Drawing.Point(24, 221);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(153, 22);
            this.txtContraseña.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.Location = new System.Drawing.Point(223, 330);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 32);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.btnVerContraseña);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.lblContraseña);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.cmbTiposDeIngreso);
            this.panel1.Location = new System.Drawing.Point(324, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 379);
            this.panel1.TabIndex = 0;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblRol.Location = new System.Drawing.Point(20, 89);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(31, 16);
            this.lblRol.TabIndex = 10;
            this.lblRol.Text = "Rol:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.linkLabel1.Location = new System.Drawing.Point(183, 270);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(112, 16);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Registrar Usuario";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnVerContraseña
            // 
            this.btnVerContraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnVerContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVerContraseña.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVerContraseña.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVerContraseña.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnVerContraseña.Location = new System.Drawing.Point(183, 221);
            this.btnVerContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerContraseña.Name = "btnVerContraseña";
            this.btnVerContraseña.Size = new System.Drawing.Size(29, 23);
            this.btnVerContraseña.TabIndex = 11;
            this.btnVerContraseña.Text = "👁";
            this.btnVerContraseña.UseVisualStyleBackColor = false;
            this.btnVerContraseña.Click += new System.EventHandler(this.btnVerContraseña_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.ColorAzul;
            this.ClientSize = new System.Drawing.Size(683, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbTiposDeIngreso;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnVerContraseña;
    }
}