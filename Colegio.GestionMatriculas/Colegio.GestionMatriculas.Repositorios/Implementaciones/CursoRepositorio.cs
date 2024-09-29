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
    public class CursoRepositorio : RepositorioBase<TblCurso>, ICursoRepositorio
    {
        private BdGestionColegioContext _contexto;

        public CursoRepositorio(BdGestionColegioContext context) : base(context)
        {
            _contexto = context;
        }
    }
}
