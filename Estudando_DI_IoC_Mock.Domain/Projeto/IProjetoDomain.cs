using System;
using System.Collections.Generic;
using System.Text;

namespace Estudando_DI_IoC_Mock.Domain.Projeto
{
    public interface IProjetoDomain
    {
        (bool sucesso, string mensagem) Efetivar(string sigla);
    }
}
