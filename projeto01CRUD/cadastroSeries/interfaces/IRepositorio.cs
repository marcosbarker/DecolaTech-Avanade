using System.Collections.Generic;

namespace cadastroSeries.interfaces
{
    public interface IRepositorio<T> // o T é um tipo generico, sera substituido por Series
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}