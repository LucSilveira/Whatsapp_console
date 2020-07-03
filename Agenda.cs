using System.Collections.Generic;
using System.IO;

namespace Whatsapp
{
    public class Agenda : IAgenda
    {
        public List<Contato> Contatos { get; set; }
        private const string PATH = "DataBase/AgendaContato.csv";


        /// <summary>
        /// Método para criação do arquivo e diretório
        /// </summary>
        public Agenda()
        {
            // Separando o caminho entre a pasta e o arquivo
            string pasta = PATH.Split('/')[0];

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }






        public void ExcluirContato(Contato _contato)
        {
            throw new System.NotImplementedException();
        }

        public void IncluirContato(Contato _contato)
        {
            throw new System.NotImplementedException();
        }

        public void ListarContato()
        {
            throw new System.NotImplementedException();
        }
    }
}