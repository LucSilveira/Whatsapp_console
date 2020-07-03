using System;
using System.Collections.Generic;

namespace Whatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Contato contato = new Contato("Teste02", "+5511962553590");

            Agenda agenda = new Agenda();

            agenda.IncluirContato(contato);

            agenda.ExcluirContato("Teste02");

            List<Contato> lista = agenda.ListarContatos();

            foreach (Contato ctt in lista)
            {
                System.Console.WriteLine($"R$ {ctt.Nome} - {ctt.Telefone}");
            }
        }
    }
}
