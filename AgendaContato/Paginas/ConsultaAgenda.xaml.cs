﻿using AgendaContato.Model;
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
    public partial class ConsultaAgenda : ContentPage
    {
        public ConsultaAgenda()
        {
            InitializeComponent();
        }
        public void GoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CadastroAgenda());
        }

        public void GoMinhaAgenda(object sender, EventArgs args)
        {
            Navigation.PushAsync(new MinhaAgendaCadastrada());
        }

        public void MaisDetalhesActions(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGes = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Agenda  agenda = tapGes.CommandParameter as Agenda;
            Navigation.PushAsync(new Detalhe(agenda));
        }

    }
}