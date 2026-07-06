using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Trabajo_final.Mantenimientos
{
  public class MantEvento
  {
    public DataTable CargarComboCliente()
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        cn.Open();
        SqlDataAdapter da = new SqlDataAdapter("SELECT IdCliente, NombreCliente FROM Clientes", cn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;        
      }
    }

    public DataTable CargarEventos()
    {

      string query = @"
                        SELECT e.IdEvento, c.NombreCliente AS Cliente, e.TipoEvento,
                               CONVERT(varchar, e.FechaEntrega, 103) AS FechaEntrega, e.LugarEvento, e.EstadoSolicitud
                        FROM Eventos e
                        INNER JOIN Clientes c ON e.IdCliente = c.IdCliente";


      using (SqlConnection cn = Conexion.GetConectar())
      {
          SqlDataAdapter da = new SqlDataAdapter(query, cn);
        DataTable dt = new DataTable();
        da.Fill(dt);

        return dt;
      }

    }

    public int AddUpdate(int idEvento, int idCliente, string tipo, DateTime fecha, string lugar, string estado)
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        cn.Open();

        if (idEvento == 0)
        {
          SqlCommand cmd = new SqlCommand(
              "INSERT INTO Eventos (IdCliente, TipoEvento, LugarEvento, FechaEntrega, EstadoSolicitud) VALUES (@IdCliente, @TipoEvento, @LugarEvento, @FechaEntrega, @EstadoSolicitud)", cn);
          cmd.Parameters.AddWithValue("@IdCliente", idCliente);
          cmd.Parameters.AddWithValue("@TipoEvento", tipo);
          cmd.Parameters.AddWithValue("@FechaEntrega", fecha);
          cmd.Parameters.AddWithValue("@LugarEvento", lugar);
          cmd.Parameters.AddWithValue("@EstadoSolicitud", estado);
          cmd.ExecuteNonQuery();
          return 1;
        }
        else
        {
          SqlCommand cmd = new SqlCommand(
              "UPDATE Eventos SET IdCliente=@IdCliente, TipoEvento=@TipoEvento, FechaEntrega=@FechaEntrega, LugarEvento=@LugarEvento, EstadoSolicitud=@EstadoSolicitud WHERE IdEvento=@Id", cn);
          cmd.Parameters.AddWithValue("@IdCliente", idCliente);
          cmd.Parameters.AddWithValue("@TipoEvento", tipo);
          cmd.Parameters.AddWithValue("@FechaEntrega", fecha);
          cmd.Parameters.AddWithValue("@LugarEvento", lugar);
          cmd.Parameters.AddWithValue("@EstadoSolicitud", estado);
          cmd.Parameters.AddWithValue("@Id", idEvento);
          cmd.ExecuteNonQuery();
          return 1;
        }
      }
    }

    public int DeleteEvento(int idEvento)
    {

      using (SqlConnection cn = Conexion.GetConectar())
      {
        try
        {
          cn.Open();
          SqlCommand cmd = new SqlCommand("DELETE FROM Eventos WHERE IdEvento=@IdEvento", cn);
          cmd.Parameters.AddWithValue("@IdEvento", idEvento);
          cmd.ExecuteNonQuery();
          return 1;
        }
        catch (Exception ex)
        {
          return 0;
        }
      }
    }

  }
}
