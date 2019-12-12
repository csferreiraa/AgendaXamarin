using AgendaContato.Banco;
using AgendaContato.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaContato.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditarAgenda : ContentPage
    {
        private Agenda agenda { get; set; }
        public EditarAgenda(Agenda agenda)
        {
            InitializeComponent();
            this.agenda = agenda;
            Nome.Text = agenda.Nome;
            Sobrenome.Text = agenda.Sobrenome;
            Telefone.Text = agenda.Telefone;
            TipoTelefone.IsToggled = (agenda.TipoTelofone == "Pessoal") ? false : true;
            Email.Text = agenda.Email;
        }

        public void SalvarAction(object sender, EventArgs args)
        {
            agenda.Nome = Nome.Text;
            agenda.Sobrenome = Sobrenome.Text;
            agenda.Telefone = Telefone.Text;
            agenda.TipoTelofone = (TipoTelefone.IsToggled) ? "Pessoal" : "Trabalho";
            agenda.Email = Email.Text;
            DataBase database = new DataBase();
            database.Update(agenda);
            App.Current.MainPage = new NavigationPage(new MinhaAgendaCadastrada());

        }
    }
}