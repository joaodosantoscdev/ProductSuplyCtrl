using ProductSupply.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSupply.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();

        List<Notificacao> ObterNotificaçoes();

        void Handle(Notificacao notificacao);
    }
}
