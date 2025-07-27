using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FormReporteBajoStock : Form
    {
        public FormReporteBajoStock(List<ReporteProductoBajoStock> productos)
        {
            InitializeComponent();
            dataGridView1.DataSource = productos;
        }

    }
}