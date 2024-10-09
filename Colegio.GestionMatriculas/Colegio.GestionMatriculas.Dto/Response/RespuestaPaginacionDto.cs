namespace Colegio.GestionMatriculas.Dto.Response
{
    public class RespuestaPaginacionDto<T> : RespuestaBaseDto
    {
        public ICollection<T>? Data { get; set; }
        public int TotalPagina { get; set; }
        public int TotalFilas { get; set; }
    }
}
