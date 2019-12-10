using AgendaContato.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaContato.Banco
{
    public class AcessoBanco { 


        private SQLiteConnection _conexao;
        public AcessoBanco()
        {
            _conexao = new SQLiteConnection();
        }

        public List<Agenda> Consultar()
        {
            return null;
        }
        public void Cadastro(Agenda agenda)
        {

        }

        public void Update(Agenda agenda)
        {

        }
        public void Delete(int id)
        {

        }
    }
}
