using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FormReporteMasVendido : Form
    {
        public FormReporteMasVendido(List<ReporteProductoMasVendido> reporte)
        {
            InitializeComponent();
            if (reporte != null && reporte.Count > 0)
            {
                dataGridView1.DataSource = reporte;
                this.lblMensaje.Text = "Top productos más vendidos:";
            }
            else
            {
                this.lblMensaje.Text = "No hay ventas registradas.";
            }
        }
    }
}