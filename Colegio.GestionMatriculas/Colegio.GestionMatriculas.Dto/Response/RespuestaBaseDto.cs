namespace Colegio.GestionMatriculas.Dto.Response
{
    public class RespuestaBaseDto
    {
        public string? message { get; set; }
        public bool success { get; set; }
    }

    public class RespuestaBaseDto<T> : RespuestaBaseDto
    {
        public T? Data { get; set; }
    }
}
