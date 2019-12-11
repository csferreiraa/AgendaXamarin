using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using AgendaContato.Banco;
using System.IO;
using AgendaContato.Droid.Banco;

[assembly: Dependency(typeof(Caminho))]

namespace AgendaContato.Droid.Banco
{
    public class Caminho : ICaminho
    {
        public string GetCaminho(string NomeArquivoBanco)
        {
            var url = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var urlBanco = Path.Combine(url, NomeArquivoBanco);
            return urlBanco;
        }
    }
}