using Colegio.GestionMatriculas.AccesoDatos.Contexto;
using Colegio.GestionMatriculas.Entidades;
using Colegio.GestionMatriculas.Repositorios.Interfaces;

namespace Colegio.GestionMatriculas.Repositorios.Implementaciones
{
    public class DocenteRepositorio : RepositorioBase<TblDocente>, IDocenteRepositorio
    {
        private BdGestionColegioContext _contexto;

        public DocenteRepositorio(BdGestionColegioContext context) : base(context)
        {
            _contexto = context;
        }
    }
}
