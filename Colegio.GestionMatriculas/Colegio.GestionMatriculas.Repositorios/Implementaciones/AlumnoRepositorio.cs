using Colegio.GestionMatriculas.AccesoDatos.Contexto;
using Colegio.GestionMatriculas.Entidades;
using Colegio.GestionMatriculas.Repositorios.Interfaces;

namespace Colegio.GestionMatriculas.Repositorios.Implementaciones
{
    public class AlumnoRepositorio : RepositorioBase<TblAlumno>, IAlumnoRepositorio
    {
        private BdGestionColegioContext _contexto;

        public AlumnoRepositorio(BdGestionColegioContext context) : base(context)
        {
            _contexto = context;
        }
    }
}
