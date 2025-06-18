namespace CapaPresentacion
{
    partial class FormProducto
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBPrecio = new System.Windows.Forms.TextBox();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lblBusquedaPor = new System.Windows.Forms.Label();
            this.listProducto = new System.Windows.Forms.ListView();
            this.btnRgresar = new System.Windows.Forms.Button();
            this.txtBStock = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtFiltrar);
            this.panel2.Controls.Add(this.lblBusquedaPor);
            this.panel2.Controls.Add(this.listProducto);
            this.panel2.Controls.Add(this.btnRgresar);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 395);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Datos del Producto";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBStock);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtBPrecio);
            this.panel1.Controls.Add(this.txtBNombre);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(13, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 290);
            this.panel1.TabIndex = 1;
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
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStock.Location = new System.Drawing.Point(32, 102);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(46, 18);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock:";
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
            // txtBPrecio
            // 
            this.txtBPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBPrecio.Location = new System.Drawing.Point(187, 63);
            this.txtBPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBPrecio.Name = "txtBPrecio";
            this.txtBPrecio.Size = new System.Drawing.Size(201, 22);
            this.txtBPrecio.TabIndex = 3;
            // 
            // txtBNombre
            // 
            this.txtBNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBNombre.Location = new System.Drawing.Point(187, 28);
            this.txtBNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(201, 22);
            this.txtBNombre.TabIndex = 2;
            this.txtBNombre.TextChanged += new System.EventHandler(this.txtBNombre_TextChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecio.Location = new System.Drawing.Point(32, 65);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(51, 18);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio:";
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
            // txtFiltrar
            // 
            this.txtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrar.Location = new System.Drawing.Point(617, 14);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(179, 22);
            this.txtFiltrar.TabIndex = 5;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
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
            // listProducto
            // 
            this.listProducto.HideSelection = false;
            this.listProducto.Location = new System.Drawing.Point(466, 47);
            this.listProducto.Margin = new System.Windows.Forms.Padding(4);
            this.listProducto.Name = "listProducto";
            this.listProducto.Size = new System.Drawing.Size(573, 261);
            this.listProducto.TabIndex = 3;
            this.listProducto.UseCompatibleStateImageBehavior = false;
            this.listProducto.SelectedIndexChanged += new System.EventHandler(this.listCliente_SelectedIndexChanged);
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
            // txtBStock
            // 
            this.txtBStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBStock.Location = new System.Drawing.Point(187, 100);
            this.txtBStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBStock.Name = "txtBStock";
            this.txtBStock.Size = new System.Drawing.Size(201, 22);
            this.txtBStock.TabIndex = 6;
            this.txtBStock.TextChanged += new System.EventHandler(this.txtBStock_TextChanged);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 426);
            this.Controls.Add(this.panel2);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBPrecio;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lblBusquedaPor;
        private System.Windows.Forms.ListView listProducto;
        private System.Windows.Forms.Button btnRgresar;
        private System.Windows.Forms.TextBox txtBStock;
    }
}