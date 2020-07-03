namespace Whatsapp
{
    public interface IAgenda
    {
        void IncluirContato(Contato _contato);

        void ExcluirContato(Contato _contato);

        void ListarContato();
    }
}