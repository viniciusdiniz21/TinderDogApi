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
    public class MensagemService : IMensagemService
    {
        private readonly IMensagemRepositorio _mensagemRepositorio;

        public MensagemService(IMensagemRepositorio mensagemRepositorio)
        {
            _mensagemRepositorio = mensagemRepositorio;
        }

       

        public bool AdicionarMensagem(Mensagem Men)
        {
            return _mensagemRepositorio.Adicionar(Men);
        }

        

      
    }
}
