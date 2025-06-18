using System;

namespace CapaPresentacion
{
    partial class FormCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBDireccion = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tctBCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtBCedula = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBApellido = new System.Windows.Forms.TextBox();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.listCliente = new System.Windows.Forms.ListView();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lblBusquedaPor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRgresar
            // 
            this.btnRgresar.AutoSize = true;
            this.btnRgresar.Location = new System.Drawing.Point(13, 339);
            this.btnRgresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRgresar.Name = "btnRgresar";
            this.btnRgresar.Size = new System.Drawing.Size(179, 28);
            this.btnRgresar.TabIndex = 0;
            this.btnRgresar.Text = "Regresar al Menu Principal";
            this.btnRgresar.UseVisualStyleBackColor = true;
            this.btnRgresar.Click += new System.EventHandler(this.btnRgresar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtBDireccion);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.tctBCorreoElectronico);
            this.panel1.Controls.Add(this.txtBCedula);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.lblCorreoElectronico);
            this.panel1.Controls.Add(this.lblCedula);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtBApellido);
            this.panel1.Controls.Add(this.txtBNombre);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 290);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.Location = new System.Drawing.Point(288, 230);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 32);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBDireccion
            // 
            this.txtBDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBDireccion.Location = new System.Drawing.Point(187, 176);
            this.txtBDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBDireccion.Name = "txtBDireccion";
            this.txtBDireccion.Size = new System.Drawing.Size(201, 22);
            this.txtBDireccion.TabIndex = 10;
            this.txtBDireccion.TextChanged += new System.EventHandler(this.txtBDireccion_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.Location = new System.Drawing.Point(154, 230);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 32);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tctBCorreoElectronico
            // 
            this.tctBCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tctBCorreoElectronico.Location = new System.Drawing.Point(187, 135);
            this.tctBCorreoElectronico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tctBCorreoElectronico.Name = "tctBCorreoElectronico";
            this.tctBCorreoElectronico.Size = new System.Drawing.Size(201, 22);
            this.tctBCorreoElectronico.TabIndex = 9;
            this.tctBCorreoElectronico.TextChanged += new System.EventHandler(this.tctBCorreoElectronico_TextChanged);
            // 
            // txtBCedula
            // 
            this.txtBCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBCedula.Location = new System.Drawing.Point(187, 100);
            this.txtBCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBCedula.Name = "txtBCedula";
            this.txtBCedula.Size = new System.Drawing.Size(201, 22);
            this.txtBCedula.TabIndex = 8;
            this.txtBCedula.TextChanged += new System.EventHandler(this.txtBCedula_TextChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDireccion.Location = new System.Drawing.Point(32, 178);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(69, 18);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(32, 137);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(123, 18);
            this.lblCorreoElectronico.TabIndex = 6;
            this.lblCorreoElectronico.Text = "Correo Electronico:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCedula.Location = new System.Drawing.Point(32, 102);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(55, 18);
            this.lblCedula.TabIndex = 5;
            this.lblCedula.Text = "Cedula:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Location = new System.Drawing.Point(32, 230);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 32);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBApellido
            // 
            this.txtBApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBApellido.Location = new System.Drawing.Point(187, 63);
            this.txtBApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBApellido.Name = "txtBApellido";
            this.txtBApellido.Size = new System.Drawing.Size(201, 22);
            this.txtBApellido.TabIndex = 3;
            this.txtBApellido.TextChanged += new System.EventHandler(this.txtxBApellido_TextChanged);
            // 
            // txtBNombre
            // 
            this.txtBNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBNombre.Location = new System.Drawing.Point(187, 28);
            this.txtBNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(201, 22);
            this.txtBNombre.TabIndex = 2;
            this.txtBNombre.TextChanged += new System.EventHandler(this.txtxBNombre_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblApellido.Location = new System.Drawing.Point(32, 65);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 18);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombre.Location = new System.Drawing.Point(32, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // listCliente
            // 
            this.listCliente.HideSelection = false;
            this.listCliente.Location = new System.Drawing.Point(466, 47);
            this.listCliente.Margin = new System.Windows.Forms.Padding(4);
            this.listCliente.Name = "listCliente";
            this.listCliente.Size = new System.Drawing.Size(797, 261);
            this.listCliente.TabIndex = 3;
            this.listCliente.UseCompatibleStateImageBehavior = false;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrar.Location = new System.Drawing.Point(617, 14);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(179, 22);
            this.txtFiltrar.TabIndex = 5;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged_1);
            // 
            // lblBusquedaPor
            // 
            this.lblBusquedaPor.AutoSize = true;
            this.lblBusquedaPor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBusquedaPor.Location = new System.Drawing.Point(466, 16);
            this.lblBusquedaPor.Name = "lblBusquedaPor";
            this.lblBusquedaPor.Size = new System.Drawing.Size(134, 18);
            this.lblBusquedaPor.TabIndex = 7;
            this.lblBusquedaPor.Text = "Busqueda (Nombre):";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtFiltrar);
            this.panel2.Controls.Add(this.lblBusquedaPor);
            this.panel2.Controls.Add(this.listCliente);
            this.panel2.Controls.Add(this.btnRgresar);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1270, 395);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Datos del Cliente";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 420);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void txtxBNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBNombre.Text)) // Primera letra en mayúscula
            {
                int selStart = txtBNombre.SelectionStart;
                string texto = txtBNombre.Text;
                string capitalizado = char.ToUpper(texto[0]) + texto.Substring(1);
                if (texto != capitalizado)
                {
                    txtBNombre.Text = capitalizado;
                    txtBNombre.SelectionStart = selStart;
                }
            }
        }

        #endregion

        private System.Windows.Forms.Button btnRgresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBApellido;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtBDireccion;
        private System.Windows.Forms.TextBox tctBCorreoElectronico;
        private System.Windows.Forms.TextBox txtBCedula;
        private System.Windows.Forms.ListView listCliente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lblBusquedaPor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}