using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Trabajo_final.Mantenimientos
{
  public class MantInventario
  {

    public DataTable CargarInventario()
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        SqlDataAdapter da = new SqlDataAdapter(
            "SELECT IdArticulo, NombreArticulo, Descripcion, CantidadDisponible, PrecioAlquiler FROM Inventario", cn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
      }
    }

    public int AddUpdate(int idSeleccionado, string NombreArticulo, string Descripcion, int CantidadDisponible, decimal PrecioAlquiler)
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        cn.Open();

        if (idSeleccionado == 0)
        {
          SqlCommand cmd = new SqlCommand(
              "INSERT INTO Inventario (NombreArticulo, Descripcion, CantidadDisponible, PrecioAlquiler) VALUES (@NombreArticulo, @Descripcion, @CantidadDisponible, @PrecioAlquiler)", cn);
          cmd.Parameters.AddWithValue("@NombreArticulo", NombreArticulo);
          cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
          cmd.Parameters.AddWithValue("@CantidadDisponible", CantidadDisponible);
          cmd.Parameters.AddWithValue("@PrecioAlquiler", PrecioAlquiler);
          cmd.ExecuteNonQuery();
          return 1;
        }
        else
        {

          SqlCommand cmd = new SqlCommand(
              "UPDATE Inventario SET NombreArticulo=@NombreArticulo, Descripcion=@Descripcion, CantidadDisponible=@CantidadDisponible, PrecioAlquiler=@PrecioAlquiler WHERE IdArticulo=@Id", cn);
          cmd.Parameters.AddWithValue("@NombreArticulo", NombreArticulo);
          cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
          cmd.Parameters.AddWithValue("@CantidadDisponible", CantidadDisponible);
          cmd.Parameters.AddWithValue("@PrecioAlquiler", PrecioAlquiler);
          cmd.Parameters.AddWithValue("@Id", idSeleccionado);
          cmd.ExecuteNonQuery();
          return 1;
        }

      }
    }

    public int DeleteInventario(int id)
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        cn.Open();
        SqlCommand cmd = new SqlCommand("DELETE FROM Inventario WHERE IdArticulo=@Id", cn);
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.ExecuteNonQuery();
        return 1;
      }
    }

  }
}
