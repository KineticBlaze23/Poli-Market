namespace CapaPresentacion
{
    partial class FormRegistrarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVerContraseña;
        private System.Windows.Forms.Button btnVerConfirmarContraseña;

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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerConfirmarContraseña = new System.Windows.Forms.Button();
            this.btnVerContraseña = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblUsuario.Location = new System.Drawing.Point(14, 106);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtUsuario.Location = new System.Drawing.Point(179, 103);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(120, 26);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblContraseña.Location = new System.Drawing.Point(14, 155);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(82, 19);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtContraseña.Location = new System.Drawing.Point(179, 152);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(120, 26);
            this.txtContraseña.TabIndex = 3;
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(14, 204);
            this.lblConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(147, 19);
            this.lblConfirmarContraseña.TabIndex = 4;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña:";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(179, 202);
            this.txtConfirmarContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '*';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(120, 26);
            this.txtConfirmarContraseña.TabIndex = 5;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblRol.Location = new System.Drawing.Point(14, 254);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(31, 19);
            this.lblRol.TabIndex = 6;
            this.lblRol.Text = "Rol:";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(179, 251);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(120, 27);
            this.cmbRol.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnRegistrar.Location = new System.Drawing.Point(17, 315);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 37);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCancelar.Location = new System.Drawing.Point(201, 315);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.cmbRol);
            this.panel1.Controls.Add(this.lblContraseña);
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.btnVerConfirmarContraseña);
            this.panel1.Controls.Add(this.txtConfirmarContraseña);
            this.panel1.Controls.Add(this.btnVerContraseña);
            this.panel1.Controls.Add(this.lblConfirmarContraseña);
            this.panel1.Location = new System.Drawing.Point(324, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 379);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registro";
            // 
            // btnVerConfirmarContraseña
            // 
            this.btnVerConfirmarContraseña.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerConfirmarContraseña.Location = new System.Drawing.Point(303, 201);
            this.btnVerConfirmarContraseña.Name = "btnVerConfirmarContraseña";
            this.btnVerConfirmarContraseña.Size = new System.Drawing.Size(29, 28);
            this.btnVerConfirmarContraseña.TabIndex = 12;
            this.btnVerConfirmarContraseña.Text = "👁";
            this.btnVerConfirmarContraseña.UseVisualStyleBackColor = true;
            this.btnVerConfirmarContraseña.Click += new System.EventHandler(this.btnVerConfirmarContraseña_Click);
            // 
            // btnVerContraseña
            // 
            this.btnVerContraseña.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnVerContraseña.Location = new System.Drawing.Point(303, 152);
            this.btnVerContraseña.Name = "btnVerContraseña";
            this.btnVerContraseña.Size = new System.Drawing.Size(29, 28);
            this.btnVerContraseña.TabIndex = 12;
            this.btnVerContraseña.Text = "👁";
            this.btnVerContraseña.UseVisualStyleBackColor = true;
            this.btnVerContraseña.Click += new System.EventHandler(this.btnVerContraseña_Click);
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
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.ColorAzul;
            this.ClientSize = new System.Drawing.Size(683, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistrarUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}