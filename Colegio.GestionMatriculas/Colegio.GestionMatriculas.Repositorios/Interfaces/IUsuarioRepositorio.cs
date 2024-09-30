using Colegio.GestionMatriculas.Entidades.Seguridad;
using Colegio.GestionMatriculas.Entidades.Seguridad.Resultados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio.GestionMatriculas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<UsuarioColaboradorResult> ObtenerColaboradorPorUsuario(string usuario);
        Task<UsuarioPermisoInfo> ListarPermisosPorUsuario(string usuario);
        Task<UsuarioPermisoInfo> AutenticarUsuario(string usuario, string clave);
    }
}
