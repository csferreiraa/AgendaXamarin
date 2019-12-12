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
    public partial class DetalharContato : ContentPage
    {
        public DetalharContato(Agenda agenda)
        {
            InitializeComponent();
            BindingContext = agenda;
        }
    }
}