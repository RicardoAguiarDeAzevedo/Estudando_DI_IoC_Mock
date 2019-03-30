using System;
using System.Collections.Generic;
using System.Text;

namespace Estudando_DI_IoC_Mock.Model.Entidade
{
    public interface ICandidatoProjeto
    {
        string Sigla { get; set; }



        IProjeto Projeto { get; set; }
    }
}
