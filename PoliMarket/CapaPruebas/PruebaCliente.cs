using System;
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
    }
}
