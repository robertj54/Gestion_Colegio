//using Colegio.GestionMatriculas.Entidades.Negocio;
using Colegio.GestionMatriculas.Entidades;
using System.Linq.Expressions;

namespace Colegio.GestionMatriculas.Repositorios.Interfaces
{
    public interface IRepositorioBase<TEntity> where TEntity : EntidadBase
    {
        Task<ICollection<TEntity>> ListAsync();
        Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicado);

        Task<ICollection<TInfo>> ListAsync<TInfo>(
            Expression<Func<TEntity, bool>> predicado,
            Expression<Func<TEntity, TInfo>> selector);

        Task<(ICollection<TInfo> Collection, int TotalRegistros)> ListAsync<TInfo, TKey>(
            Expression<Func<TEntity, bool>> predicado,
            Expression<Func<TEntity, TInfo>> selector,
            Expression<Func<TEntity, TKey>> orderBy,
            int pagina = 1, int filas = 5);

        Task<TEntity?> FindByIdAsync(int id);
        Task<TInfo> FindOneAsync<TInfo>(
    Expression<Func<TEntity, bool>> predicado,
    Expression<Func<TEntity, TInfo>> selector);

        Task<TEntity> AddAsync(TEntity entity);
        Task<bool> DeleteByIdAsync(int id);
    }
}
