using Estudando_DI_IoC_Mock.Model.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudando_DI_IoC_Mock.Data
{
    public interface IProjetoData
    {
        IProjeto Buscar(string sigla);

        bool ProjetoEstaAtivo(IProjeto projeto);
    }
}
