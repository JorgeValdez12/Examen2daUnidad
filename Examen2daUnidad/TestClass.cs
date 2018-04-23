using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2daUnidad
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestSuma()
        {
            int[] arreglo = new int[] { 5, 7, 8, 8, 9, 9, 9, 9, 10, 10 };
            Operaciones nuevo = new Operaciones();
            var esperado = 84;
            Assert.AreEqual(nuevo.suma(arreglo), esperado);
        }

        [Test]
        public void TestPromedio()
        {
            int[] arreglo = new int[] { 5, 7, 8, 8, 9, 9, 9, 9, 10, 10 };
            Operaciones nuevo = new Operaciones();
            double esperado = 8.4;
            double obtenido = nuevo.promedio(arreglo);
            Assert.AreEqual(obtenido, esperado);
        }

        [Test]
        public void TestModa()
        {
            int[] arreglo = new int[] { 5, 7, 8, 8, 9, 9, 9, 9, 10, 10 };
            Operaciones nuevo = new Operaciones();
            var esperado = 9;
            Assert.AreEqual(nuevo.moda(arreglo), esperado);
        }

        [Test]
        public void TestMediana()
        {
            int[] arreglo = new int[] { 5, 7, 8, 8, 9, 9, 9, 9, 10, 10 };
            Operaciones nuevo = new Operaciones();
            var esperado = 9;
            Assert.AreEqual(nuevo.mediana(arreglo),esperado);
        }
    }
}
