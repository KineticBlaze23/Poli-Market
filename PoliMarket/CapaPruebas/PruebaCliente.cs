using System;
using System.Linq;
using CapaNegocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapaPruebas
{
    [TestClass]
    public class PruebaCliente
    {
        [TestMethod]
        public void RegistrarCliente()
        {
            // Arrange
            var negocio = new NegocioCliente();

            // Act
            var cliente1 = negocio.RegistrarCliente("Carlos", "Ramírez", "1234567890", "carlos@gmail.com", "Nayon");
            var cliente2 = negocio.RegistrarCliente("Laura", "Díaz", "0987654321", "laura@gmail.com", "Nayon");

            // Assert
            Assert.AreEqual(1, cliente1.IdCliente);
            Assert.AreEqual("Carlos", cliente1.Nombre);
            Assert.AreEqual("Ramírez", cliente1.Apellido);

            Assert.AreEqual(2, cliente2.IdCliente);
            Assert.AreEqual("Laura", cliente2.Nombre);
            Assert.AreEqual("Díaz", cliente2.Apellido);
        }

        [TestMethod]
        public void EliminarCliente()
        {
            var negocio = new NegocioCliente();
            var cliente = negocio.RegistrarCliente("Carlos", "Ramírez", "1234567890", "carlos@gmail.com", "Nayon");

            bool eliminado = negocio.EliminarCliente(cliente.IdCliente);
            var clientesRestantes = negocio.ListarClientes();

            Assert.IsTrue(eliminado);
            Assert.AreEqual(0, clientesRestantes.Count);
        }

        [TestMethod]
        public void ActualizarCliente()
        {
            var negocio = new NegocioCliente();
            var cliente = negocio.RegistrarCliente("Ana", "Pérez", "1111111111", "ana@gmail.com", "Quito");
            cliente.Nombre = "Anita";
            cliente.Apellido = "Paredes";
            var actualizado = negocio.ActualizarCliente(cliente);
            var clienteBuscado = negocio.BuscarPorId(cliente.IdCliente);
            Assert.IsTrue(actualizado);
            Assert.AreEqual("Anita", clienteBuscado.Nombre);
            Assert.AreEqual("Paredes", clienteBuscado.Apellido);
        }

        [TestMethod]
        public void BuscarPorNombreCliente()
        {
            var negocio = new NegocioCliente();
            negocio.RegistrarCliente("Mario", "Lopez", "2222222222", "mario@gmail.com", "Quito");
            negocio.RegistrarCliente("Mariana", "Gomez", "3333333333", "mariana@gmail.com", "Quito");
            var resultados = negocio.BuscarPorNombre("Mari");
            Assert.AreEqual(2, resultados.Count);
            Assert.IsTrue(resultados.Any(c => c.Nombre == "Mario"));
            Assert.IsTrue(resultados.Any(c => c.Nombre == "Mariana"));
        }

        [TestMethod]
        public void BuscarPorIdCliente()
        {
            var negocio = new NegocioCliente();
            var cliente = negocio.RegistrarCliente("Luis", "Martínez", "4444444444", "luis@gmail.com", "Quito");
            var encontrado = negocio.BuscarPorId(cliente.IdCliente);
            Assert.IsNotNull(encontrado);
            Assert.AreEqual("Luis", encontrado.Nombre);
        }

        [TestMethod]
        public void ListarClientes()
        {
            var negocio = new NegocioCliente();
            negocio.RegistrarCliente("Pedro", "Suarez", "5555555555", "pedro@gmail.com", "Quito");
            negocio.RegistrarCliente("Lucía", "Mora", "6666666666", "lucia@gmail.com", "Quito");
            var lista = negocio.ListarClientes();
            Assert.AreEqual(2, lista.Count);
            Assert.AreEqual("Pedro", lista[0].Nombre);
            Assert.AreEqual("Lucía", lista[1].Nombre);
        }
    }
}
