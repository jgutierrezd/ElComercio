using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte02.Common.Data
{
    public interface IManager<TEntity, in TKey, in TFilter>
    {
        bool Agregar(TEntity entity);
        bool Eliminar(TKey key);
        TEntity Buscar(TKey key);
        bool Actualizar(TEntity entity);
        IEnumerable<TEntity> Listar(TFilter filter);
    }
}
