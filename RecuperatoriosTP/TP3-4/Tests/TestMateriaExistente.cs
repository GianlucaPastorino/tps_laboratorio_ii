using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Tests
{
    [TestClass]
    public class TestMateriaExistente
    {
        [TestMethod]
        public void ChequearMateriaExistente_MateriaNoPresenteEnInstitucion_DeberiaRetornarFalse()
        {
            Materia materia = new Materia("Catequesis", EModalidad.Presencial, 10, EDia.Lunes, ETurno.Mañana);

            bool resultado = materia.ChequearMateriaExistente();

            Assert.IsFalse(resultado);
        }
    }
}
