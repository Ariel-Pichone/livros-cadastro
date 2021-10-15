using System;
using System.Collections.Generic;
using Livros.interfaces;

namespace Livros
{
    public class SerieRepositorio : IRepositorio<Livro>
    {
        private List<Livro> listaLivro = new List<Livro>();
        public void Atualiza(int id, Livro objeto)
        {
            listaLivro[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaLivro[id].Excluir();
        }

        public void Insere(Livro objeto)
        {
            listaLivro.Add(objeto);
        }

        public List<Livro> Lista()
        {
            return listaLivro;
        }

        public int ProximoId()
        {
            return listaLivro.Count;
        }

        public Livro RetornaPorId(int id)
        {
            return listaLivro[id];
        }
    }
}