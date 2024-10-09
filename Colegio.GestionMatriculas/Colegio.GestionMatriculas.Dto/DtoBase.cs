namespace Colegio.GestionMatriculas.Dto
{
    public class DtoBase
    {
        /// <summary>
        /// Fecha creación registro
        /// </summary>
        public DateTime FechaCreacionDto { get; set; } = DateTime.Now;

        /// <summary>
        /// Usuario creación registro
        /// </summary>
        public string UsuarioCreacionDto { get; set; } = Environment.UserName!;
    }
}
