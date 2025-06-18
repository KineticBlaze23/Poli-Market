namespace CapaPresentacion
{
    partial class FormVenta
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
            this.btnRgresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRgresar
            // 
            this.btnRgresar.AutoSize = true;
            this.btnRgresar.Location = new System.Drawing.Point(687, 415);
            this.btnRgresar.Name = "btnRgresar";
            this.btnRgresar.Size = new System.Drawing.Size(75, 26);
            this.btnRgresar.TabIndex = 2;
            this.btnRgresar.Text = "Regresar";
            this.btnRgresar.UseVisualStyleBackColor = true;
            this.btnRgresar.Click += new System.EventHandler(this.btnRgresar_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRgresar);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRgresar;
    }
}