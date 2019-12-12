using AgendaContato.Banco;
using AgendaContato.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaContato.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastrarContato : ContentPage
    {
        public CadastrarContato(Agenda agenda = null)
        {
            InitializeComponent();
        }

        public void SalvarAction(object sender, EventArgs args)
        {
            //TODO - Obter dados da tela
            Agenda agenda = new Agenda();
            agenda.Nome = Nome.Text;
            agenda.Sobrenome = Sobrenome.Text;
            agenda.Telefone = Telefone.Text;
            agenda.TipoTelofone = (TipoTelefone.IsToggled) ? "Pessoal" : "Trabalho";
            agenda.Email = Email.Text;
            //TODO - Salvar informações no Banco

            DataBase database = new DataBase();
            database.Create(agenda);
            App.Current.MainPage = new NavigationPage(new ConsultarContato());
        }
    }
}