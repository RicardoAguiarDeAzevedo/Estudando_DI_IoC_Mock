using Estudando_DI_IoC_Mock.Data;
using Estudando_DI_IoC_Mock.Model.Enumeradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudando_DI_IoC_Mock.Domain.Projeto
{
    public class ProjetoDomain : IProjetoDomain
    {
        IProjetoData _projetoData;

        public ProjetoDomain(IProjetoData projetoData)
        {
            _projetoData = projetoData;
        }
        
        public (bool sucesso, string mensagem) Efetivar(string sigla)
        {
            var projeto = _projetoData.Buscar(sigla);

            if (_projetoData.ProjetoEstaAtivo(projeto) == false)
                return (false, "Status do projeto impede sua efetivação");

            //Lógica...

            return (true, "Efetivado com sucesso");
        }
    }
}
