using AgendaContato.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace AgendaContato.Banco
{
    public class DataBase { 


        private SQLiteConnection _conexao;
        public DataBase()
        {
            var dep = DependencyService.Get<ICaminho>();
            string url = dep.GetCaminho("database.sqlite");

            _conexao = new SQLiteConnection(url);
        }

        public List<Agenda> Consultar()
        {
            return null;
        }

        public void Create(Agenda agenda)
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
