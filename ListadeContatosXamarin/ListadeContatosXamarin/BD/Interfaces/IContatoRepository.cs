using ListadeContatosXamarin.Models;
using System.Collections.Generic;

namespace ListadeContatosXamarin.BD.Interfaces
{
    public interface IContatoRepository
    {
        List<Contato> ObterTodosContatos();
        Contato ObterContato(int contatoId);
        List<Contato> PesquisarContato(string filtro);
        void AdicionarContato(Contato contato);
        void EditarContato(Contato contato);
        void DeletarContato(int contatoId);
        void DeletarTodosContatos();
    }
}