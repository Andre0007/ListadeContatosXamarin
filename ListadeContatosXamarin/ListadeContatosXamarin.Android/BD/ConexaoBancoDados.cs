using ListadeContatosXamarin.BD.Interfaces;
using ListadeContatosXamarin.Droid.BD;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(ConexaoBancoDados))]
namespace ListadeContatosXamarin.Droid.BD
{
    public class ConexaoBancoDados : IConexaoBancoDados
    {
        public string Conexao(string NomeArquivoBD)
        {
            string stringConexao = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string bancoDados = Path.Combine(stringConexao, NomeArquivoBD);
            return bancoDados;
        }
    }
}