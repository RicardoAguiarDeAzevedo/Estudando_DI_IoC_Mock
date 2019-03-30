using Estudando_DI_IoC_Mock.Model.Entidade;
using Estudando_DI_IoC_Mock.Model.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estudando_DI_IoC_Mock.Data
{
    public class ProjetoData : IProjetoData
    {
        List<IProjeto> _projetos;

        public ProjetoData()
        {
            _projetos = new List<IProjeto>();
            _projetos.Add(new Projeto() { Sigla = "TEST0001", Status = ProjetoStatus.Ativo });
            _projetos.Add(new Projeto() { Sigla = "TEST0002", Status = ProjetoStatus.Inativo });
            _projetos.Add(new Projeto() { Sigla = "TEST0003", Status = ProjetoStatus.Efetivado });
        }

        public IProjeto Buscar(string sigla)
        {
            return _projetos.SingleOrDefault(p => p.Sigla == sigla);
        }

        public bool ProjetoEstaAtivo(IProjeto projeto)
        {
            return projeto.Status == ProjetoStatus.Ativo;
        }
    }
}
