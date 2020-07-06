namespace Whatsapp
{
    public class Mensagem
    {
        public string TextoMensagem { get; set; }

        public string Destinatario { get; set; }


        public void EnviarMenagem(Contato _contato)
        {
            Destinatario = _contato.Nome;
            System.Console.WriteLine($"Destinatario {_contato.Nome}");

            System.Console.WriteLine(TextoMensagem);
        }
    }
}