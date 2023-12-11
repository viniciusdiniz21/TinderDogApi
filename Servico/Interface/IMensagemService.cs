using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Interface
{
    public interface IMensagemService
    {
        public bool AdicionarMensagem(Mensagem Men);

        //public Task<bool> AdicionarMensagem(string conteudo);

    }
}
