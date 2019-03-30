using Estudando_DI_IoC_Mock.Data;
using Estudando_DI_IoC_Mock.Domain.Projeto;
using Estudando_DI_IoC_Mock.Model.Enumeradores;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Estudando_DI_IoC_Mock.Domain.Test
{
    [TestClass]
    public class ProjetoDomainTest
    {
        [TestMethod]
        public void Efetivar_ProjetoAtivo_DeveEfetivar()
        {
            //Cenário
            string sigla = "TEST0001";
            var mock = new Mock<IProjetoData>();
            var projetoDomain = new ProjetoDomain(mock.Object);
            mock.Setup(x => x.Buscar(sigla)).Returns(
                new Model.Entidade.Projeto()
                {
                    Sigla = sigla,
                    Status = ProjetoStatus.Ativo
                });


            //Ação
            var result = projetoDomain.Efetivar(sigla);


            //Resultado
            Assert.IsFalse(result.sucesso);
        }

        [TestMethod]
        public void Efetivar_ProjetoInativo_NaoDeveEfetivar()
        {
            //Cenário
            string sigla = "TEST0001";
            var mock = new Mock<IProjetoData>();
            var projetoDomain = new ProjetoDomain(mock.Object);
            mock.Setup(x => x.Buscar(sigla)).Returns(
                new Model.Entidade.Projeto()
                {
                    Sigla = sigla,
                    Status = ProjetoStatus.Inativo
                });


            //Ação
            var result = projetoDomain.Efetivar(sigla);


            //Resultado
            Assert.IsFalse(result.sucesso);
        }
    }
}
