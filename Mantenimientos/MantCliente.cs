using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Trabajo_final.Mantenimientos
{
  public class MantCliente
  {

    public DataTable CargarClientes()
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        cn.Open();
        SqlDataAdapter da = new SqlDataAdapter(
            "SELECT IdCliente, NombreCliente, Telefono, Correo FROM Clientes", cn);
        DataTable dt = new DataTable();
        da.Fill(dt);

        return dt;
        
      }
    }

    public int AddUpdate(int IdCliente, string NombreCliente, string Telefono, string Correo)
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        cn.Open();

        if (IdCliente == 0)
        {
          SqlCommand cmd = new SqlCommand(
              "INSERT INTO Clientes (NombreCliente, Telefono, Correo) VALUES (@NombreCliente, @Telefono, @Correo)", cn);
          cmd.Parameters.AddWithValue("@NombreCliente", NombreCliente);
          cmd.Parameters.AddWithValue("@Telefono", Telefono);
          cmd.Parameters.AddWithValue("@Correo", Correo);
          return cmd.ExecuteNonQuery();
        }
        else
        {
          SqlCommand cmd = new SqlCommand(
              "UPDATE Clientes SET NombreCliente=@NombreCliente, Telefono=@Telefono, Correo=@Correo WHERE IdCliente=@Id", cn);
          cmd.Parameters.AddWithValue("@NombreCliente", NombreCliente);
          cmd.Parameters.AddWithValue("@Telefono", Telefono);
          cmd.Parameters.AddWithValue("@Correo", Correo);
          cmd.Parameters.AddWithValue("@Id", IdCliente);
          return cmd.ExecuteNonQuery();
        }
      }
    }

    public void DeleteCliente(int id)
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        try
        {
          cn.Open();
          SqlCommand cmd = new SqlCommand("DELETE FROM Clientes WHERE IdCliente=@Id", cn);
          cmd.Parameters.AddWithValue("@Id", id);
          cmd.ExecuteNonQuery();
          MessageBox.Show("Cliente eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
  }
}
