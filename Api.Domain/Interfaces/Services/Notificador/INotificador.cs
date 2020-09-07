using Domain.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Services.Notificador
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
