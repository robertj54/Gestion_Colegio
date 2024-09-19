using Colegio.GestionMatriculas.AccesoDatos.Contexto;
using Colegio.GestionMatriculas.Entidades;
using Colegio.GestionMatriculas.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Repositorios.Implementaciones
{
    public class AlumnoRepositorio : RepositorioBase<TblAlumno>, IAlumnoRepositorio
    {
        private BdGestionColegioContext _bdGestionColegioContext;
        public AlumnoRepositorio(BdGestionColegioContext context) : base(context)
        {
            _bdGestionColegioContext = context;
        }
    }
}
