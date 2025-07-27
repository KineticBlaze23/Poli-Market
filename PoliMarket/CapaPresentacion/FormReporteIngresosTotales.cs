using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormReporteIngresosTotales : Form
    {
        public FormReporteIngresosTotales(NegocioReporte negocioReporte)
        {
            InitializeComponent();
            var ingresosPorMes = negocioReporte.ObtenerIngresosPorMes();
            dataGridView1.DataSource = ingresosPorMes.ConvertAll(x => new { Mes = x.Mes, Total = x.Total });
            double totalGeneral = 0;
            foreach (var item in ingresosPorMes)
                totalGeneral += item.Total;
            lblIngresos.Text = $"Total de Ingresos: ${totalGeneral:F2}";
        }
    }
}