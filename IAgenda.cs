using System.Collections.Generic;

namespace Whatsapp
{
    public interface IAgenda
    {
        void IncluirContato(Contato _contato);

        void ExcluirContato(string _contato);

        List<Contato> ListarContatos();
    }
}