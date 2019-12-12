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
    public partial class ConsultarContato : ContentPage
    {
        List<Agenda> Lista { get; set; }

        public ConsultarContato()
        {
            InitializeComponent();
            DataBase database = new DataBase();
            Lista = database.Consultar();
            ListaAgenda.ItemsSource = database.Consultar();
            lblCount.Text = Lista.Count.ToString();
        }

        public void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastrarContato());
        }

        public void GoMinhaAgenda(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhaAgendaCadastrada());
        }

        public void MaisDetalhesActions(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGes = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Agenda agenda = tapGes.CommandParameter as Agenda;
            Navigation.PushAsync(new DetalharContato(agenda));
        }

        public void PesquisarAction(object sender, TextChangedEventArgs args)
        {
            ListaAgenda.ItemsSource = Lista.Where(a => a.Nome.ToUpper().Contains(args.NewTextValue)).ToList();
        }
    }
}