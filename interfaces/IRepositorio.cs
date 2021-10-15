using System.Collections.Generic;

namespace livros.interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista(); //retorna lista de T
        T RetornaPorId(int id); //retorna um T a partir de id fornecido
        void Insere(T Entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}