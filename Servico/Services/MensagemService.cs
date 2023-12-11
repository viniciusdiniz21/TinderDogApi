using Dados.Interface;
using Dados.Repositorio;
using Dominio.Entities;
using Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Servico.Services
{
    internal class MensagemService : IMensagemService
    {
        private readonly IMensagemService _mensagemService;

        public MensagemService(IMensagemService mensagemService)
        {
            _mensagemService = mensagemService;
        }

       

        public bool AdicionarMensagem(Mensagem Men)
        {
            return _mensagemService.AdicionarMensagem(Men);
        }

        

      
    }
}
