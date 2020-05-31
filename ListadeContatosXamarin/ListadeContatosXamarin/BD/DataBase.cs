using ListadeContatosXamarin.BD.Interfaces;
using ListadeContatosXamarin.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ListadeContatosXamarin.BD
{
    public class DataBase
    {
        private static SQLiteConnection _conexao;
        public DataBase()
        {
            var dependencyService = DependencyService.Get<IConexaoBancoDados>();
            string stringConexao = dependencyService.Conexao("contatos.sqlite");
            _conexao = new SQLiteConnection(stringConexao);
            _conexao.CreateTable<Contato>();
        }

        public void AdicionarContato(Contato contato)
        {
            _conexao.Insert(contato);
        }

        public Contato ObterContato(int id)
        {
            return _conexao.Table<Contato>().FirstOrDefault(c => c.IdContato == id);
        }

        public List<Contato> ObterTodosContatos()
        {
            return (from dadosContato in _conexao.Table<Contato>() select dadosContato).ToList();
        }

        public void EditarContato(Contato contato)
        {
            _conexao.Update(contato);
        }

        public List<Contato> PesquisarContato(string filtro)
        {
            /* Verifica se o paramentro esta vazio ou nulo,
             * para quando o usuario apagar os parametros de pesquisa no serachbar
             * a lista carregar os contatos em ordem alfabetica. */
            if (string.IsNullOrEmpty(filtro))
                return ObterTodosContatos(); //-> O método ObterTodosContatos retorna a lista em ordem alfabética.

            return _conexao.Table<Contato>().Where(c => c.NomeContato.Contains(filtro)).ToList();
        }

        public void DeletarContato(int id)
        {
            _conexao.Delete<Contato>(id);
        }

        public void DeletarTodosContatos()
        {
            _conexao.DeleteAll<Contato>();
        }
    }
}