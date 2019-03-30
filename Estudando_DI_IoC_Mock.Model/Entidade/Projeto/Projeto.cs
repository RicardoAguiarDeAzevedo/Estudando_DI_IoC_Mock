using Estudando_DI_IoC_Mock.Model.Enumeradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudando_DI_IoC_Mock.Model.Entidade
{
    public class Projeto : IProjeto
    {
        public string Sigla { get; set; }

        public ProjetoStatus Status { get; set; }

        public ICollection<ICandidatoProjeto> CandidatoProjeto { get; set; }
    }
}
