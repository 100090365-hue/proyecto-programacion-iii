using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Trabajo_final.Mantenimientos
{
  public class MantFactura
  {

    public DataTable CargarClientes()
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

    public DataTable CargarArticulos()
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        cn.Open();
        string query = "SELECT IdArticulo, NombreArticulo, Descripcion, (NombreArticulo + ISNULL(' - ' + Descripcion, '')) AS DisplayName, PrecioAlquiler FROM Inventario";
        SqlDataAdapter da = new SqlDataAdapter(query, cn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        
        return dt;
      }
    }

    public DataTable CargarEventosPorCliente(int idCliente)
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        cn.Open();
        string query = @"SELECT IdEvento, TipoEvento
                         FROM Eventos 
                         WHERE IdCliente = @IdCliente";

        using (SqlCommand cmd = new SqlCommand(query, cn))
        {
          cmd.Parameters.AddWithValue("@IdCliente", idCliente);

          SqlDataAdapter da = new SqlDataAdapter(cmd);
          DataTable dt = new DataTable();
          da.Fill(dt);

          return dt;
        }
      }
    }

    public DataTable CargarFacturas(string? id)
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        if (id != null && int.TryParse(id, out int idEvento))
        {
          string query = @"
            SELECT 
              de.IdDetalle as Codigo,
              e.TipoEvento AS Evento,
              (i.NombreArticulo + ISNULL(' - ' + i.Descripcion, '')) AS Articulo,
              de.CantidadUsada AS Cantidad,
              SUM(de.CantidadUsada * i.PrecioAlquiler) AS MontoTotal
            FROM DetalleEvento de 
              INNER JOIN Eventos e ON de.IdEvento = e.IdEvento 
              INNER JOIN Clientes c ON e.IdCliente = c.IdCliente
              INNER JOIN Inventario i ON de.IdArticulo = i.IdArticulo
            WHERE
              de.IdEvento = @IdEvento
            GROUP BY
              c.IdCliente,
              c.NombreCliente,
              e.IdEvento,
              e.TipoEvento,
              i.NombreArticulo,
              i.Descripcion,
              de.IdDetalle,
              de.CantidadUsada;";

          using (SqlCommand cmd = new SqlCommand(query, cn))
          {
            cmd.Parameters.AddWithValue("@IdEvento", idEvento);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
          }
        }
        else
        {
          SqlDataAdapter da = new SqlDataAdapter(
             @"select
                 de.IdDetalle as Codigo,
                 c.NombreCliente as Cliente,
                 e.TipoEvento as Evento,
                 (i.NombreArticulo + ISNULL(' - ' + i.Descripcion, '')) as Articulo,
                 de.CantidadUsada as Cantidad
               from DetalleEvento de 
                 INNER JOIN Eventos e ON de.IdEvento = e.IdEvento 
                 INNER JOIN Clientes c ON e.IdCliente = c.IdCliente 
                 INNER JOIN Inventario i ON de.IdArticulo = i.IdArticulo", cn);
          DataTable dt = new DataTable();
          da.Fill(dt);
          return dt;
        }
      }
    }

    public DataTable MontoTotalCliente(int IdCliente, int IdEvento)
    {
      string query = $@"
      SELECT 
        c.NombreCliente,
        e.TipoEvento,
        SUM(de.CantidadUsada * i.PrecioAlquiler) AS MontoTotalEvento
      FROM DetalleEvento de
        INNER JOIN Eventos e ON de.IdEvento = e.IdEvento
        INNER JOIN Clientes c ON e.IdCliente = c.IdCliente
        INNER JOIN Inventario i ON de.IdArticulo = i.IdArticulo
      WHERE c.IdCliente = {IdCliente} AND e.IdEvento = {@IdEvento}
      GROUP BY c.NombreCliente, e.TipoEvento;
      ";

      using (SqlConnection cn = Conexion.GetConectar())
      {
        SqlDataAdapter da = new SqlDataAdapter(query, cn);
        DataTable dt = new DataTable();
        da.Fill(dt);

        return dt;
      }

    }

    public int AddUpdateEventos(int id, string? evento, string? articulo, int cantidad)
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        try
        {
          cn.Open();

          if (id == 0)
          {

            SqlCommand cmd = new SqlCommand(
               "INSERT INTO DetalleEvento(IdEvento, IdArticulo, CantidadUsada) VALUES(@IdEvento, @IdArticulo, @CantidadUsada)", cn);
            cmd.Parameters.AddWithValue("@IdEvento", evento);
            cmd.Parameters.AddWithValue("@IdArticulo", articulo);
            cmd.Parameters.AddWithValue("@CantidadUsada", cantidad);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Articulo Agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return 1;
          }
          else
          {
            SqlCommand cmd = new SqlCommand(
                "UPDATE DetalleEvento SET IdEvento=@IdEvento, IdArticulo=@IdArticulo, CantidadUsada=@CantidadUsada WHERE IdDetalle=@IdDetalle", cn);
            cmd.Parameters.AddWithValue("@IdEvento", evento);
            cmd.Parameters.AddWithValue("@IdArticulo", articulo);
            cmd.Parameters.AddWithValue("@CantidadUsada", cantidad);
            cmd.Parameters.AddWithValue("@IdDetalle", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Datos actualizados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 1;
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return 0;
        }
      }
    }
    
    public int AddFactura(int idCliente, int IdEvento, decimal MontoTotal, string MetodoPago)
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        cn.Open();

        string query = @"INSERT INTO Facturacion
                         (IdCliente, IdEvento, FechaFactura, MontoTotal, MetodoPago, EstadoFactura)
                         VALUES (@IdCliente, @IdEvento, @FechaFactura, @MontoTotal, @MetodoPago, @EstadoFactura)";

        using (SqlCommand cmd = new SqlCommand(query, cn))
        {

          // Parámetros desde los controles del formulario
          cmd.Parameters.AddWithValue("@IdCliente", idCliente);
          cmd.Parameters.AddWithValue("@IdEvento", IdEvento);
          cmd.Parameters.AddWithValue("@FechaFactura", DateTime.Now);
          //ESTO NO VA ASI, SE TIENE QUE CALCULAR EL MONTO TOTAL DE LOS ARTICULOS.
          cmd.Parameters.AddWithValue("@MontoTotal", MontoTotal);
          cmd.Parameters.AddWithValue("@MetodoPago", MetodoPago);
          cmd.Parameters.AddWithValue("@EstadoFactura", "Activo");

          cmd.ExecuteNonQuery();
        }

        MessageBox.Show("Factura registrada correctamente.");

        return 1;
      }
    }

    public decimal PrecioAlquiler(int idArticulo)
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        cn.Open();
        string query = "SELECT PrecioAlquiler FROM Inventario WHERE IdArticulo = @IdArticulo";

        using (SqlCommand cmd = new SqlCommand(query, cn))
        {
          cmd.Parameters.AddWithValue("@IdArticulo", idArticulo);
          var result = cmd.ExecuteScalar();
          if (result != null)
          {
            return Convert.ToDecimal(result);
          }
        }
      }

      return 0;

    }

    public int DeleteArticulo(int id)
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        try
        {
          cn.Open();
          SqlCommand cmd = new SqlCommand("DELETE FROM DetalleEvento WHERE IdDetalle=@Id", cn);
          cmd.Parameters.AddWithValue("@Id", id);
          cmd.ExecuteNonQuery();
          MessageBox.Show("Articulo eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
          return 1;
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return 0;
        }
      }
    }

  }
}
