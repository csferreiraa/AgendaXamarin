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
            ConsultarAgenda();

        }

        private void ConsultarAgenda()
        {
            DataBase database = new DataBase();
            Lista = database.Consultar();
            ListaAgenda.ItemsSource = database.Consultar();
            lblCount.Text = Lista.Count.ToString();
        }

        public void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastrarContato());
        }


        public void MaisDetalhesActions(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGes = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Agenda agenda = tapGes.CommandParameter as Agenda;
            Navigation.PushAsync(new DetalharContato(agenda));
        }


        public void EditarAction(object sender, EventArgs args)
        {
            Label lblEditar = (Label)sender;
            TapGestureRecognizer tapGes = (TapGestureRecognizer)lblEditar.GestureRecognizers[0];
            Agenda agenda = tapGes.CommandParameter as Agenda;
            Navigation.PushAsync(new EditarContato(agenda));
        }
        public void ExcluirAction(object sender, EventArgs args)
        {
            Label lblExcluir = (Label)sender;
            TapGestureRecognizer tapGes = (TapGestureRecognizer)lblExcluir.GestureRecognizers[0];
            Agenda agenda = tapGes.CommandParameter as Agenda;
            DataBase database = new DataBase();
            database.Delete(agenda);
            ConsultarAgenda();
        }


        public void PesquisarAction(object sender, TextChangedEventArgs args)
        {
            ListaAgenda.ItemsSource = Lista.Where(a => a.Nome.Contains(args.NewTextValue)).ToList();
        }
    }
}