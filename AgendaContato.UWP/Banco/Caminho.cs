using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaContato.Banco;
using Xamarin.Forms;
using System.IO;
using AgendaContato.UWP.Banco;
using Windows.Storage;

[assembly: Dependency(typeof(Caminho))]
namespace AgendaContato.UWP.Banco
{
    public class Caminho : ICaminho
    {
        public string GetCaminho(string NomeArquivoBanco)
        {
            string url = ApplicationData.Current.LocalFolder.Path;
            string urlBanco = Path.Combine(url, NomeArquivoBanco);
            return urlBanco;
        }
    }
}
