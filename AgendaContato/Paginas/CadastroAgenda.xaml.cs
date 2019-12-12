using AgendaContato.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AgendaContato.Banco;

namespace AgendaContato.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroAgenda : ContentPage
    {
        public CadastroAgenda()
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

            //TODO - Voltar para a tela de pesquisa
            Navigation.PopAsync();
        }
    }
}