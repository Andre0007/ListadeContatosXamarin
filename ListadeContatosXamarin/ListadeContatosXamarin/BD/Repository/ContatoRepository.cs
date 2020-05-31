using ListadeContatosXamarin.BD.Interfaces;
using ListadeContatosXamarin.Models;
using System.Collections.Generic;

namespace ListadeContatosXamarin.BD.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly DataBase _dataBase;

        public ContatoRepository()
        {
            _dataBase = new DataBase();
        }

        public void AdicionarContato(Contato contato)
        {
            _dataBase.AdicionarContato(contato);
        }

        public void DeletarContato(int contatoId)
        {
            _dataBase.DeletarContato(contatoId);
        }

        public void DeletarTodosContatos()
        {
            _dataBase.DeletarTodosContatos();
        }

        public void EditarContato(Contato contato)
        {
            _dataBase.EditarContato(contato);
        }

        public Contato ObterContato(int contatoId)
        {
            return _dataBase.ObterContato(contatoId);
        }

        public List<Contato> ObterTodosContatos()
        {
            return _dataBase.ObterTodosContatos();
        }

        public List<Contato> PesquisarContato(string filtro)
        {
            return _dataBase.PesquisarContato(filtro);
        }
    }
}