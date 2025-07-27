namespace CapaPresentacion
{
    partial class FormAutorizacionAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsuarioAdmin;
        private System.Windows.Forms.Label lblContrasenaAdmin;
        private System.Windows.Forms.TextBox txtUsuarioAdmin;
        private System.Windows.Forms.TextBox txtContrasenaAdmin;
        private System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUsuarioAdmin = new System.Windows.Forms.Label();
            this.lblContrasenaAdmin = new System.Windows.Forms.Label();
            this.txtUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.txtContrasenaAdmin = new System.Windows.Forms.TextBox();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuarioAdmin
            // 
            this.lblUsuarioAdmin.AutoSize = true;
            this.lblUsuarioAdmin.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblUsuarioAdmin.Location = new System.Drawing.Point(18, 94);
            this.lblUsuarioAdmin.Name = "lblUsuarioAdmin";
            this.lblUsuarioAdmin.Size = new System.Drawing.Size(148, 19);
            this.lblUsuarioAdmin.TabIndex = 0;
            this.lblUsuarioAdmin.Text = "Usuario administrador:";
            // 
            // lblContrasenaAdmin
            // 
            this.lblContrasenaAdmin.AutoSize = true;
            this.lblContrasenaAdmin.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblContrasenaAdmin.Location = new System.Drawing.Point(18, 135);
            this.lblContrasenaAdmin.Name = "lblContrasenaAdmin";
            this.lblContrasenaAdmin.Size = new System.Drawing.Size(82, 19);
            this.lblContrasenaAdmin.TabIndex = 1;
            this.lblContrasenaAdmin.Text = "Contraseña:";
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(166, 91);
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(150, 26);
            this.txtUsuarioAdmin.TabIndex = 2;
            // 
            // txtContrasenaAdmin
            // 
            this.txtContrasenaAdmin.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtContrasenaAdmin.Location = new System.Drawing.Point(166, 132);
            this.txtContrasenaAdmin.Name = "txtContrasenaAdmin";
            this.txtContrasenaAdmin.PasswordChar = '*';
            this.txtContrasenaAdmin.Size = new System.Drawing.Size(150, 26);
            this.txtContrasenaAdmin.TabIndex = 3;
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAutorizar.Location = new System.Drawing.Point(47, 191);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(100, 23);
            this.btnAutorizar.TabIndex = 4;
            this.btnAutorizar.Text = "Autorizar";
            this.btnAutorizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCancelar.Location = new System.Drawing.Point(167, 191);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAutorizar);
            this.panel1.Controls.Add(this.lblUsuarioAdmin);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.lblContrasenaAdmin);
            this.panel1.Controls.Add(this.txtContrasenaAdmin);
            this.panel1.Controls.Add(this.txtUsuarioAdmin);
            this.panel1.Location = new System.Drawing.Point(74, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 234);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Autorizacion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CapaPresentacion.Properties.Resources.Logo6;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(139, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 67);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormAutorizacionAdmin
            // 
            this.AcceptButton = this.btnAutorizar;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.ColorAzul;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(493, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAutorizacionAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorización de Administrador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
