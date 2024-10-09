using Colegio.GestionMatriculas.AccesoDatos.Contexto;
using Colegio.GestionMatriculas.Entidades;
using Colegio.GestionMatriculas.Repositorios.Interfaces;

namespace Colegio.GestionMatriculas.Repositorios.Implementaciones
{
    public class GradoSeccionRepositorio : RepositorioBase<TblGradoSeccion>, IGradoSeccionRepositorio
    {
        private BdGestionColegioContext _contexto;

        public GradoSeccionRepositorio(BdGestionColegioContext context) : base(context)
        {
            _contexto = context;
        }
    }
}
