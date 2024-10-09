namespace Colegio.GestionMatriculas.Comun
{
    public static class Utils
    {
        public static int CalcularTotalPaginas(int total_elementos, int total_filas)
        {
            return (int)Math.Ceiling((double)total_elementos / total_filas);
        }
    }
}
