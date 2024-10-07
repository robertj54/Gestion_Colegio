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
    public class DocenteRepositorio : RepositorioBase<TblDocente>, IDocenteRepositorio
    {
        private BdGestionColegioContext _contexto;

        public DocenteRepositorio(BdGestionColegioContext context) : base(context)
        {
            _contexto = context;
        }
    }
}
