using System;
using System.Collections.Generic;
using Livros.interfaces;

namespace Livros
{
    public class SerieRepositorio : IRepositorio<Livro>
    {
        private List<Livro> listaLivro = new List<Livro>();
        public void Atualiza(int id, Livro entidade)
        {
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Livro Entidade)
        {
            throw new NotImplementedException();
        }

        public List<Livro> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Livro RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}