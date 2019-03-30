using Estudando_DI_IoC_Mock.Data;
using Estudando_DI_IoC_Mock.Model.Enumeradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudando_DI_IoC_Mock.Domain.Projeto
{
    public class ProjetoDomain : IProjetoDomain
    {
        public (bool sucesso, string mensagem) Efetivar(string sigla)
        {
            if (ProjetoEstaAtivo(sigla) == false)
                return (false, "Status do projeto impede sua efetivação");

            //Lógica...

            return (true, "Efetivado com sucesso");
        }

        public bool ProjetoEstaAtivo(string sigla)
        {
            return new ProjetoData().Buscar(sigla)?.Status == ProjetoStatus.Ativo;
        }
    }
}
