using AgendaContato.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;


namespace AgendaContato.Banco
{
    public class DataBase
    {

        private SQLiteConnection _conexao;
        public DataBase()
        {
            var dep = DependencyService.Get<ICaminho>();
            string url = dep.GetCaminho("database.sqlite");

            _conexao = new SQLiteConnection(url);
            _conexao.CreateTable<Agenda>();
        }

        public List<Agenda> Consultar()
        {
            return _conexao.Table<Agenda>().ToList();
        }

        public List<Agenda> Pesquisar(string palavra)
        {
            return _conexao.Table<Agenda>().Where(a => a.Nome.Contains(palavra)).ToList();
        }

        public Agenda GetId(int id)
        {
            return _conexao.Table<Agenda>().Where(a => a.Id == id).FirstOrDefault();
        }

        public void Create(Agenda agenda)
        {
            _conexao.Insert(agenda);
        }

        public void Update(Agenda agenda)
        {
            _conexao.Update(agenda);
        }

        public void Delete(Agenda agenda)
        {
            _conexao.Delete(agenda);
        }
    }
}
