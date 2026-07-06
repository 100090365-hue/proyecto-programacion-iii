using Diseño_Trabajo_final.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Diseño_Trabajo_final
{
  public partial class FormFacturas : Form
  {

    MantFactura mantFactura = new MantFactura();

    //private void CargarMontoEventosPorCliente(int idCliente)
    //{
    //  using (SqlConnection cn = Conexion.GetConectar())
    //  {
    //    cn.Open();
    //    string query = @"SELECT 
    //                        e.IdEvento,
    //                        e.TipoEvento,
    //                        e.LugarEvento,
    //                        e.FechaEntrega,
    //                        SUM(de.CantidadUsada * i.PrecioAlquiler) AS MontoTotal
    //                     FROM DetalleEvento de
    //                     INNER JOIN Eventos e ON de.IdEvento = e.IdEvento
    //                     INNER JOIN Clientes c ON e.IdCliente = c.IdCliente
    //                     INNER JOIN Inventario i ON de.IdArticulo = i.IdArticulo
    //                     WHERE c.IdCliente = @IdCliente
    //                     GROUP BY e.IdEvento, e.TipoEvento, e.LugarEvento, e.FechaEntrega";

    //    using (SqlCommand cmd = new SqlCommand(query, cn))
    //    {
    //      cmd.Parameters.AddWithValue("@IdCliente", idCliente);

    //      SqlDataAdapter da = new SqlDataAdapter(cmd);
    //      DataTable dt = new DataTable();
    //      da.Fill(dt);

    //      dataGridView1.DataSource = dt; // Mostrar resultados en el grid
    //    }
    //  }
    //}

    private void CargarClientesCombo()
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        try
        {
          comboCliente.DisplayMember = "NombreCliente";
          comboCliente.ValueMember = "IdCliente";
          comboCliente.DataSource = mantFactura.CargarClientes();
          comboCliente.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void CargarArticulosCombo()
    {
      try
      {
        comboArticu.DisplayMember = "DisplayName";
        comboArticu.ValueMember = "IdArticulo";
        comboArticu.DataSource = mantFactura.CargarArticulos();
        comboArticu.SelectedIndex = -1;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al cargar los artículos: " + ex.Message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void CargarEventosPorCliente(int idCliente)
    {

      var dt = mantFactura.CargarEventosPorCliente(idCliente);

      if (dt.Rows.Count > 0)
      {
        comboEvento.DataSource = dt;
        comboEvento.DisplayMember = "TipoEvento"; // lo que se muestra
        comboEvento.ValueMember = "IdEvento";     // el valor real
      }
      else
      {
        // Si no hay eventos activos → limpiar
        comboEvento.DataSource = null;
        comboEvento.Items.Clear();
      }
    }

    private void CargarFacturas()
    {
      try
      {
        if (comboEvento.SelectedValue != null && 
            comboEvento.SelectedIndex != -1 && 
            int.TryParse(comboEvento.SelectedValue.ToString(), out int idEvento))
        {
          dataGridView1.DataSource = null;
          dataGridView1.DataSource = mantFactura.CargarFacturas(idEvento.ToString());

          decimal montoTotal = 0;
          foreach (DataGridViewRow row in dataGridView1.Rows)
          {
            if (row.Cells["MontoTotal"].Value != DBNull.Value && row.Cells["MontoTotal"].Value != null)
            {
              montoTotal += Convert.ToDecimal(row.Cells["MontoTotal"].Value);
            }
          }

          txtMontoTotal.Text = montoTotal.ToString("N2");
        }
        else
        {
          dataGridView1.DataSource = null;
          txtMontoTotal.Text = "0.00";
        }

        if (dataGridView1.DataSource != null)
        {
          dataGridView1.ReadOnly = true;
          dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          dataGridView1.MultiSelect = false;
          dataGridView1.AllowUserToAddRows = false;
          dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al cargar las facturas: " + ex.Message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void LimpiarCampos()
    {
      comboArticu.Text = "";
      txtCantidad.Text = "";
      txtMontoPorArt.Text = "";
      comboCliente.Text = "";
      comboEvento.Text = "";
      comboMetodoPago.Text = "";
      txtMontoTotal.Text = "";
      btnAddArticulo.Text = "➕ Agregar";
    }

    private int idSeleccionado = 0;

    public FormFacturas()
    {
      InitializeComponent();
      CargarClientesCombo();
      CargarArticulosCombo();
      //CargarEventosCombo(comboCliente.ValueMember);
      CargarFacturas();

      // Agregar iconos a los botones
      btnAddArticulo.Text = "➕ Agregar";
      button1.Text = "🧾 Facturar";
      button2.Text = "✏️ Editar";
      button3.Text = "🧹 Limpiar";
      button5.Text = "🗑️ E. Articulo";
      btnExportarExcel.Text = "📊 Excel";
    }

    private void FormFacturas_Load(object sender, EventArgs e)
    {

    }

    private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (comboCliente.SelectedValue != null && comboCliente.SelectedIndex != -1)
      {
        if (int.TryParse(comboCliente.SelectedValue.ToString(), out int idCliente))
        {
          CargarEventosPorCliente(idCliente);
        }
      }
      else
      {
        comboEvento.DataSource = null;
        comboEvento.Items.Clear();
      }
      CargarFacturas();
    }

    private void comboEvento_SelectedIndexChanged(object sender, EventArgs e)
    {
      CargarFacturas();
    }

    private void btnAddArticulo_Click(object sender, EventArgs e)
    {

      if (comboArticu.SelectedValue == null ||
        string.IsNullOrWhiteSpace(txtCantidad.Text) ||
        string.IsNullOrWhiteSpace(txtMontoPorArt.Text))
      {
        MessageBox.Show("Complete todos los campos.", "Advertencia",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (idSeleccionado == 0)
      {
        mantFactura.AddUpdateEventos(idSeleccionado, comboEvento?.SelectedValue?.ToString(), comboArticu.SelectedValue.ToString(), int.Parse(txtCantidad.Text));
      }
      else
      {
        mantFactura.AddUpdateEventos(idSeleccionado, comboEvento?.SelectedValue?.ToString(), comboArticu.SelectedValue.ToString(), int.Parse(txtCantidad.Text));
      }

      CargarFacturas();

      comboArticu.SelectedIndex = -1;
      txtCantidad.Text = "";
      txtMontoPorArt.Text = "";
      btnAddArticulo.Text = "➕ Agregar";

    }

    private void button1_Click(object sender, EventArgs e)
    {
      // 1. Validaciones
      if (comboCliente.SelectedValue == null || comboCliente.SelectedIndex == -1)
      {
        MessageBox.Show("Por favor, seleccione un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      if (comboEvento.SelectedValue == null || comboEvento.SelectedIndex == -1)
      {
        MessageBox.Show("Por favor, seleccione un evento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      if (string.IsNullOrWhiteSpace(comboMetodoPago.Text))
      {
        MessageBox.Show("Por favor, seleccione un método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      if (dataGridView1.Rows.Count == 0)
      {
        MessageBox.Show("No hay artículos agregados para facturar en este evento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // 2. Diálogo de Guardado de PDF
      using (SaveFileDialog sfd = new SaveFileDialog())
      {
        sfd.Filter = "Documentos PDF (*.pdf)|*.pdf";
        sfd.Title = "Guardar Factura como PDF";
        sfd.FileName = $"Factura_{comboCliente.Text.Replace(" ", "_")}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

        if (sfd.ShowDialog() == DialogResult.OK)
        {
          try
          {
            string pdfPath = sfd.FileName;

            // A. Registrar en Base de Datos
            int idCliente = Convert.ToInt32(comboCliente.SelectedValue);
            int idEvento = Convert.ToInt32(comboEvento.SelectedValue);
            decimal totalFactura = Convert.ToDecimal(txtMontoTotal.Text);
            string metodoPago = comboMetodoPago.Text;

            mantFactura.AddFactura(idCliente, idEvento, totalFactura, metodoPago);

            // B. Recopilar artículos de la tabla para el PDF
            List<Diseño_Trabajo_final.Servicios.FacturaItem> items = new List<Diseño_Trabajo_final.Servicios.FacturaItem>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
              if (row.Cells["Articulo"].Value != null)
              {
                items.Add(new Diseño_Trabajo_final.Servicios.FacturaItem
                {
                  Codigo = row.Cells["Codigo"].Value?.ToString() ?? "",
                  Articulo = row.Cells["Articulo"].Value?.ToString() ?? "",
                  Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                  MontoTotal = Convert.ToDecimal(row.Cells["MontoTotal"].Value)
                });
              }
            }

            // C. Generar PDF
            var pdfService = new Diseño_Trabajo_final.Servicios.PdfReportService();
            pdfService.GenerarFacturaPdf(pdfPath, comboCliente.Text, comboEvento.Text, metodoPago, totalFactura.ToString("N2"), items);

            // D. Abrir archivo PDF automáticamente
            ProcessStartInfo psi = new ProcessStartInfo
            {
              FileName = pdfPath,
              UseShellExecute = true
            };
            Process.Start(psi);

            MessageBox.Show("Factura guardada y PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // E. Limpieza
            LimpiarCampos();
            CargarFacturas();
          }
          catch (Exception ex)
          {
            MessageBox.Show("Error al generar el reporte de facturación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }

    private decimal precioArticulo = 0;
    private void comboArticu_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (comboArticu.SelectedValue != null)
      {
        int idArticulo = Convert.ToInt32(comboArticu.SelectedValue);
        precioArticulo = mantFactura.PrecioAlquiler(idArticulo);
      }
    }

    private void txtCantidad_TextChanged(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtCantidad.Text))
      {
        int cantidad;
        if (int.TryParse(txtCantidad.Text, out cantidad))
        {
          decimal total = cantidad * precioArticulo;
          txtMontoPorArt.Text = total.ToString("N2"); // formato con 2 decimales
        }
        else
        {
          txtMontoPorArt.Text = "0.00"; // si no es número válido
        }
      }
      else
      {
        txtMontoPorArt.Text = "0.00"; // si está vacío
      }
    }

    private void txtMontoTotal_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (dataGridView1.SelectedRows.Count == 0)
      {
        MessageBox.Show("Haga clic sobre una fila de la tabla para seleccionarla.", "Advertencia",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }


      DataRowView drv = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
      if (drv == null) return;

      idSeleccionado = Convert.ToInt32(drv["Codigo"]);
      comboArticu.Text = drv["Articulo"].ToString();
      txtCantidad.Text = drv["Cantidad"].ToString();

      btnAddArticulo.Text = "Actualizar";
    }

    private void button3_Click(object sender, EventArgs e)
    {
      LimpiarCampos();
      CargarFacturas();
    }

    private void button5_Click(object sender, EventArgs e)
    {

      if (dataGridView1.SelectedRows.Count == 0)
      {
        MessageBox.Show("Haga clic sobre una fila de la tabla para seleccionarla.", "Advertencia",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }


      DataRowView drv = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
      if (drv == null) return;

      int id = Convert.ToInt32(drv["Codigo"]);
      //string nombre = drv["NombreCliente"].ToString();

      DialogResult confirm = MessageBox.Show(
          $"¿Desea eliminar el articulo?",
          "Confirmar eliminación",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (confirm == DialogResult.Yes)
      {
        mantFactura.DeleteArticulo(id);
        LimpiarCampos();
        CargarFacturas();
      }
    }

    private void btnExportarExcel_Click(object sender, EventArgs e)
    {
      if (dataGridView1.Rows.Count == 0)
      {
        MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      using (SaveFileDialog sfd = new SaveFileDialog())
      {
        sfd.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
        sfd.Title = "Exportar datos a Excel";
        sfd.FileName = $"Detalle_Factura_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

        if (sfd.ShowDialog() == DialogResult.OK)
        {
          try
          {
            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
              var worksheet = workbook.Worksheets.Add("Detalle Factura");

              // Escribir cabeceras
              int colIndex = 1;
              List<int> visibleColIndices = new List<int>();
              foreach (DataGridViewColumn col in dataGridView1.Columns)
              {
                if (col.Visible)
                {
                  worksheet.Cell(1, colIndex).Value = col.HeaderText;
                  visibleColIndices.Add(col.Index);
                  colIndex++;
                }
              }

              // Escribir filas
              int rowIndex = 2;
              foreach (DataGridViewRow row in dataGridView1.Rows)
              {
                if (!row.IsNewRow)
                {
                  for (int i = 0; i < visibleColIndices.Count; i++)
                  {
                    object? val = row.Cells[visibleColIndices[i]].Value;
                    worksheet.Cell(rowIndex, i + 1).Value = val == DBNull.Value || val == null ? "" : val.ToString();
                  }
                  rowIndex++;
                }
              }

              // Formatear cabeceras (negrita)
              var headerRange = worksheet.Range(1, 1, 1, visibleColIndices.Count);
              headerRange.Style.Font.Bold = true;

              // Ajustar columnas
              worksheet.Columns().AdjustToContents();

              // Guardar archivo
              workbook.SaveAs(sfd.FileName);
            }

            MessageBox.Show("Datos exportados exitosamente a Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Abrir archivo automáticamente
            ProcessStartInfo psi = new ProcessStartInfo
            {
              FileName = sfd.FileName,
              UseShellExecute = true
            };
            Process.Start(psi);
          }
          catch (Exception ex)
          {
            MessageBox.Show("Error al exportar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }
  }
}
