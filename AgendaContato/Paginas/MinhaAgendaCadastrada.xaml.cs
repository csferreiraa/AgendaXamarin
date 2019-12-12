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
    public partial class MinhaAgendaCadastrada : ContentPage
    {
        List<Agenda> Lista { get; set; }

        public MinhaAgendaCadastrada()
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

        public void EditarAction(object sender, EventArgs args)
        {
            Label lblEditar = (Label)sender;
            TapGestureRecognizer tapGes = (TapGestureRecognizer)lblEditar.GestureRecognizers[0];
            Agenda agenda = tapGes.CommandParameter as Agenda;
            Navigation.PushAsync(new EditarAgenda(agenda));
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
    }
}