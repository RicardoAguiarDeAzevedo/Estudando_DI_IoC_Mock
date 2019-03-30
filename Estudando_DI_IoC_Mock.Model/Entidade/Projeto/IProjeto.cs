using Estudando_DI_IoC_Mock.Model.Enumeradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudando_DI_IoC_Mock.Model.Entidade
{
    public interface IProjeto
    {
        string Sigla { get; set; }

        ProjetoStatus Status { get; set; }

        ICollection<ICandidatoProjeto> CandidatoProjeto { get; set; }
    }
}
