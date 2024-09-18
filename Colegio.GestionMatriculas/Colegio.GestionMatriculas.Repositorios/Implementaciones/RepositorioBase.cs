using Colegio.GestionMatriculas.AccesoDatos.Contexto;
using Colegio.GestionMatriculas.Entidades.Negocio;
using Colegio.GestionMatriculas.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Repositorios.Implementaciones
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : EntidadBase
    {
        protected readonly BdGestionColegioContext Contexto;
        public RepositorioBase(BdGestionColegioContext context)
        {
            Contexto = context;
        }

        public Task<TEntity> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity?> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TEntity>> ListAsync()
        {
            return Contexto.Set<TEntity>()
                .Where(p=> p.Estado)
        }

        public Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TInfo>> ListAsync<TInfo>(Expression<Func<TEntity, bool>> predicado, Expression<Func<TEntity, TInfo>> selector)
        {
            throw new NotImplementedException();
        }

        public Task<(ICollection<TInfo> Collection, int TotalRegistros)> ListAsync<TInfo, TKey>(Expression<Func<TEntity, bool>> predicado, Expression<Func<TEntity, TInfo>> selector, Expression<Func<TEntity, TKey>> orderBy, int pagina = 1, int filas = 5)
        {
            throw new NotImplementedException();
        }
    }
}
