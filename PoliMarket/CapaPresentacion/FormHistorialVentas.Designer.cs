namespace CapaPresentacion
{
    partial class FormHistorialVentas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listViewVentas;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.Label labelDesde;
        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.Button btnFiltrar;
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
            this.listViewVentas = new System.Windows.Forms.ListView();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.labelDesde = new System.Windows.Forms.Label();
            this.labelHasta = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewVentas
            // 
            this.listViewVentas.FullRowSelect = true;
            this.listViewVentas.HideSelection = false;
            this.listViewVentas.Location = new System.Drawing.Point(12, 12);
            this.listViewVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewVentas.MultiSelect = false;
            this.listViewVentas.Name = "listViewVentas";
            this.listViewVentas.Size = new System.Drawing.Size(817, 350);
            this.listViewVentas.TabIndex = 0;
            this.listViewVentas.UseCompatibleStateImageBehavior = false;
            this.listViewVentas.View = System.Windows.Forms.View.Details;
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.AutoSize = true;
            this.btnEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminarVenta.Location = new System.Drawing.Point(702, 375);
            this.btnEliminarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(107, 28);
            this.btnEliminarVenta.TabIndex = 1;
            this.btnEliminarVenta.Text = "Eliminar Venta";
            this.btnEliminarVenta.UseVisualStyleBackColor = true;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(93, 375);
            this.dateTimePickerDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(132, 22);
            this.dateTimePickerDesde.TabIndex = 2;
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(320, 375);
            this.dateTimePickerHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(132, 22);
            this.dateTimePickerHasta.TabIndex = 3;
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelDesde.Location = new System.Drawing.Point(13, 379);
            this.labelDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(50, 19);
            this.labelDesde.TabIndex = 4;
            this.labelDesde.Text = "Desde:";
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelHasta.Location = new System.Drawing.Point(253, 379);
            this.labelHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(47, 19);
            this.labelHasta.TabIndex = 5;
            this.labelHasta.Text = "Hasta:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnFiltrar.Location = new System.Drawing.Point(480, 373);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // FormHistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 418);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.labelHasta);
            this.Controls.Add(this.labelDesde);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.btnEliminarVenta);
            this.Controls.Add(this.listViewVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHistorialVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial de Ventas";
            this.Load += new System.EventHandler(this.FormHistorialVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
