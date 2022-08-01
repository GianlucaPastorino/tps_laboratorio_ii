using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.IO;
using System;

namespace Tests
{
    [TestClass]
    public class TestJson
    {
        [TestMethod]
        public void EscribirJson_ArchivoInexistente_DeberiaCrearNuevoArchivo()
        {
            string path = "JsonTest.json";
            string mensaje = "Esto es una prueba unitaria";

            Serializer<string>.EscribirJson(mensaje, path);

            Assert.IsTrue(File.Exists(AppDomain.CurrentDomain.BaseDirectory + path));
        }
    }
}
