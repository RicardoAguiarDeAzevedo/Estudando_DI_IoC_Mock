using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Estudando_DI_IoC_Mock.Data.Test
{
    [TestClass]
    public class ProjetoDataTest
    {
        [TestMethod]
        public void Buscar_SiglaCorreta_DeveBuscarCorretamente()
        {
            //Cenário
            string sigla = "TEST0001";

            //Ação
            var result = new ProjetoData().Buscar(sigla);

            //Resultado
            Assert.AreEqual(sigla, result?.Sigla);
        }
    }
}
