using System;
using System.Collections.Generic;
using System.Text;

namespace Estudando_DI_IoC_Mock.Model.Entidade
{
    public class CandidatoProjeto : ICandidatoProjeto
    {
        public string Sigla { get; set; }

        public virtual IProjeto Projeto { get; set; }
    }
}
