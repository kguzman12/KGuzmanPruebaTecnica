using System.Configuration;

namespace DL
{
    public class Conexion
    {
        public static string GetConnection()
        {
            return ConfigurationManager.ConnectionStrings["KGuzmanProgramacionNCapas"].ConnectionString.ToString();
        }
    }
}