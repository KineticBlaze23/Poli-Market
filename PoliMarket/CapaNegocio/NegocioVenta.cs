using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using CapaEntidad;

namespace CapaNegocio
{
    public class NegocioVenta
    {
        private List<Venta> ventas = new List<Venta>();
        private int ultimoId = 0;

        public Venta RegistrarVenta(int idCliente, double total, DateTime? fecha = null, int idProducto = 0, int cantidad = 0, double precioUnitario = 0)
        {
            Venta nuevaVenta;
            if (idProducto > 0 && cantidad > 0 && precioUnitario > 0)
            {
                nuevaVenta = new Venta(++ultimoId, idCliente, idProducto, cantidad, precioUnitario, total, fecha ?? DateTime.Now);
            }
            else
            {
                nuevaVenta = new Venta(++ultimoId, idCliente, total, fecha ?? DateTime.Now);
            }
            ventas.Add(nuevaVenta);
            return nuevaVenta;
        }

        public bool EliminarVenta(int id, NegocioProducto negocioProducto)
        {
            var venta = ventas.FirstOrDefault(v => v.IdVenta == id);
            if (venta == null)
                return false;

            if (venta.IdProducto > 0 && venta.Cantidad > 0)
            {
                var producto = negocioProducto.BuscarPorId(venta.IdProducto);
                if (producto != null)
                {
                    producto.Stock += venta.Cantidad;
                    negocioProducto.ActualizarProducto(producto);
                }
            }
            ventas.Remove(venta);
            return true;
        }

        public Venta BuscarPorId(int id)
        {
            return ventas.FirstOrDefault(v => v.IdVenta == id);
        }

        public List<Venta> ListarVentas()
        {
            return new List<Venta>(ventas);
        }

        public void GuardarVentasEnTxt(string rutaArchivoVenta)
        {
            try
            {
                using (var writer = new StreamWriter(rutaArchivoVenta, false))
                {
                    writer.WriteLine("IdVenta,IdCliente,IdProducto,Cantidad,PrecioUnitario,Total,Fecha");
                    foreach (var venta in ventas)
                    {
                        writer.WriteLine(FormatearVentaParaArchivo(venta));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar ventas en archivo: {ex.Message}", ex);
            }
        }

        private string FormatearVentaParaArchivo(Venta venta)
        {
            return $"{venta.IdVenta},{venta.IdCliente},{venta.IdProducto},{venta.Cantidad},{venta.PrecioUnitario},{venta.Total},{venta.Fecha:dd/MM/yyyy HH:mm}";
        }

        public void CargarVentasDesdeTxt(string rutaArchivoVenta)
        {
            ventas.Clear();
            ultimoId = 0;

            try
            {
                if (!File.Exists(rutaArchivoVenta))
                    return;

                var lineas = File.ReadAllLines(rutaArchivoVenta).Skip(1); // Saltar encabezado

                foreach (var linea in lineas)
                {
                    if (EsLineaVentaValida(linea, out Venta venta))
                    {
                        ventas.Add(venta);
                        if (venta.IdVenta > ultimoId)
                            ultimoId = venta.IdVenta;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar ventas desde archivo: {ex.Message}", ex);
            }
        }

        private bool EsLineaVentaValida(string linea, out Venta venta)
        {
            venta = null;
            if (string.IsNullOrWhiteSpace(linea)) return false;
            var columnas = linea.Split(',');
            if (columnas.Length > 7)
                columnas = columnas.Take(7).ToArray();
            if (columnas.Length == 7 &&
                int.TryParse(columnas[0], out int idVenta) &&
                int.TryParse(columnas[1], out int idCliente) &&
                int.TryParse(columnas[2], out int idProducto) &&
                int.TryParse(columnas[3], out int cantidad) &&
                double.TryParse(columnas[4], out double precioUnitario) &&
                double.TryParse(columnas[5], out double total) &&
                DateTime.TryParse(columnas[6], out DateTime fecha))
            {
                venta = new Venta(idVenta, idCliente, idProducto, cantidad, precioUnitario, total, fecha);
                return true;
            }
            Debug.WriteLine($"Línea de venta ignorada por formato incorrecto: {linea}");
            return false;
        }
    }
}