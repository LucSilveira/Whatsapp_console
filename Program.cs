using System;
using System.Collections.Generic;

namespace Whatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Contato contato = new Contato("a23", "+5511912345678");

            Agenda agenda = new Agenda();

            // agenda.IncluirContato(contato);

            agenda.ExcluirContato("Teste");

            List<Contato> lista = agenda.ListarContatos();

            foreach (Contato ctt in lista)
            {
                System.Console.WriteLine($"R$ {ctt.Nome} - {ctt.Telefone}");
            }
        }
    }
}
