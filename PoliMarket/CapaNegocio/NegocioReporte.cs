using System;
using System.Collections.Generic;
using System.Linq;
using CapaEntidad;

namespace CapaNegocio
{
    public class NegocioReporte
    {
        private const int StockBajo = 20; // Umbral fijo para stock bajo
        private readonly NegocioProducto _negocioProducto;
        private readonly NegocioVenta _negocioVenta;

        public NegocioReporte(NegocioProducto negocioProducto, NegocioVenta negocioVenta) // Constructor
        {
            _negocioProducto = negocioProducto;
            _negocioVenta = negocioVenta;
        }

        public List<ReporteProductoBajoStock> ObtenerProductosBajoStock()
        {
            return ObtenerProductosBajoStock(StockBajo);
        }

        public List<ReporteProductoBajoStock> ObtenerProductosBajoStock(int umbral) // Método para obtener productos con stock bajo
        {
            return _negocioProducto.ListarProductos()
                .Where(p => p.Stock <= umbral)
                .Select(p => new ReporteProductoBajoStock
                {
                    IdProducto = p.IdProducto,
                    Nombre = p.Nombre,
                    Stock = p.Stock
                }).ToList();
        }

        public List<ReporteProductoMasVendido> ObtenerProductosMasVendidos(int top = 3)  // Método para obtener los productos más vendidos  
        {
            var ventas = _negocioVenta.ListarVentas();
            var productosMasVendidos = ventas
                .GroupBy(v => v.IdProducto)
                .Select(g => new { IdProducto = g.Key, Cantidad = g.Sum(v => v.Cantidad) })
                .OrderByDescending(x => x.Cantidad)
                .Take(top)
                .ToList();

            var resultado = new List<ReporteProductoMasVendido>();
            foreach (var item in productosMasVendidos)
            {
                var producto = _negocioProducto.BuscarPorId(item.IdProducto);
                resultado.Add(new ReporteProductoMasVendido
                {
                    IdProducto = item.IdProducto,
                    Nombre = producto?.Nombre ?? "Desconocido",
                    CantidadVendida = item.Cantidad
                });
            }
            return resultado;
        }

        public ReporteIngresosTotales ObtenerIngresosTotales()  // Método para obtener el total de ingresos
        {
            var total = _negocioVenta.ListarVentas().Sum(v => v.Total);
            return new ReporteIngresosTotales { TotalIngresos = total };
        }

        public List<(string Mes, double Total)> ObtenerIngresosPorMes()  // Método para obtener ingresos por mes    
        {
            var ventas = _negocioVenta.ListarVentas();
            var ingresosPorMes = ventas
                .GroupBy(v => v.Fecha.ToString("MM/yyyy"))
                .Select(g => (Mes: g.Key, Total: g.Sum(v => v.Total)))
                .OrderBy(x => x.Mes)
                .ToList();
            return ingresosPorMes;
        }
    }
}