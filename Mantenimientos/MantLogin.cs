using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Trabajo_final.Mantenimientos
{
  public class MantLogin
  {
    public string? LoginData(string userName, string password)
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        cn.Open();
        string query = "SELECT Rol FROM Usuario WHERE NombreUsuario=@usuario AND Clave=@clave";

        using (SqlCommand cmd = new SqlCommand(query, cn))
        {
          cmd.Parameters.AddWithValue("@usuario", userName);
          cmd.Parameters.AddWithValue("@clave", password);

          using (SqlDataReader reader = cmd.ExecuteReader())
          {
            if (reader.Read())
            {
              return reader["Rol"]?.ToString();
            }
            return null;
          }
        }
      }
    }

  }
}
