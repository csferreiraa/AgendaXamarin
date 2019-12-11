using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using AgendaContato.Banco;
using Xamarin.Essentials;
using System.IO;
using AgendaContato.iOS.Banco;
using Xamarin.Forms;

[assembly: Dependency(typeof(Caminho))]
namespace AgendaContato.iOS.Banco
{
    public class Caminho : ICaminho
    {
        public string GetCaminho(string NomeArquivoBanco)
        {
            string url = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string urlBiblioteca = Path.Combine(url, "..", "Library");
            string urlBanco = Path.Combine(urlBiblioteca, NomeArquivoBanco);
            return urlBanco;
        }
    }
}