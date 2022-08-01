using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Entidades;

namespace Tests
{
    [TestClass]
    public class TestValidarPlan
    {
        [TestMethod]
        public void ValidarPlan_AlumnoNulo_DeberiaDevolverFalse()
        {
            Plan plan = new Plan(null, 3, new List<Materia>(), ETipo.Semanal, EMedioDePago.Débito);

            bool resultado = plan.Validar();

            Assert.IsFalse(resultado);
        }

    }
}
