using Diseño_Trabajo_final.Mantenimientos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Diseño_Trabajo_final
{
  public partial class FormEventos : Form
  {
    private int idSeleccionado = 0;
    MantEvento mantEvento = new MantEvento();

    public FormEventos()
    {
      InitializeComponent();
      button1.Text = "💾 Guardar";
      button2.Text = "✏️ Editar";
      button3.Text = "🧹 Limpiar";
      button5.Text = "🗑️ Eliminar";
    }

    private void FormEventos_Load(object sender, EventArgs e)
    {
      CargarClientesCombo();
      CargarEventos();

      if (comboBox2.Items.Count == 0)
      {
        comboBox2.Items.Add("Activo");
        comboBox2.Items.Add("Inactivo");
      }
    }

    private void CargarClientesCombo()
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        try
        {

          var dt = mantEvento.CargarComboCliente();

          comboBox1.DisplayMember = "NombreCliente";
          comboBox1.ValueMember = "IdCliente";
          comboBox1.DataSource = dt;
          comboBox1.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void CargarEventos()
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        try
        {

          dataGridView1.DataSource = null;
          dataGridView1.DataSource = mantEvento.CargarEventos();


          dataGridView1.ReadOnly = true;
          dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          dataGridView1.MultiSelect = false;
          dataGridView1.AllowUserToAddRows = false;
          dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error al cargar eventos: " + ex.Message, "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (comboBox1.SelectedValue == null ||
          string.IsNullOrWhiteSpace(textBox3.Text) ||
          string.IsNullOrWhiteSpace(textBox1.Text))
      {
        MessageBox.Show("Complete todos los campos.", "Advertencia",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      int idCliente = Convert.ToInt32(comboBox1.SelectedValue);
      string tipo = textBox3.Text.Trim();
      DateTime fecha = dateTimePicker1.Value;
      string lugar = textBox1.Text.Trim();
      string estado = comboBox2.SelectedItem?.ToString() ?? "Activo";

      try
      {

        if (idSeleccionado == 0)
        {
          mantEvento.AddUpdate(idSeleccionado, idCliente, tipo, fecha, lugar, estado);
          MessageBox.Show("Evento guardado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
          mantEvento.AddUpdate(idSeleccionado, idCliente, tipo, fecha, lugar, estado);
          MessageBox.Show("Evento actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        CargarEventos();
        LimpiarCampos();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
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

      idSeleccionado = Convert.ToInt32(drv["IdEvento"]);
      comboBox1.Text = drv["Cliente"].ToString();
      textBox3.Text = drv["TipoEvento"].ToString();
      textBox1.Text = drv["LugarEvento"].ToString();
      comboBox2.Text = drv["EstadoSolicitud"].ToString();

      if (DateTime.TryParse(drv["FechaEntrega"].ToString(), out DateTime fecha))
        dateTimePicker1.Value = fecha;

      button1.Text = "Actualizar";
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

      int id = Convert.ToInt32(drv["IdEvento"]);
      string tip = drv["TipoEvento"].ToString();

      DialogResult confirm = MessageBox.Show(
          $"¿Desea eliminar el evento '{tip}'?",
          "Confirmar eliminación",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (confirm == DialogResult.Yes)
      {
        mantEvento.DeleteEvento(id);
        MessageBox.Show("Evento eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        CargarEventos();
      }

      //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void button3_Click(object sender, EventArgs e) => LimpiarCampos();

    private void LimpiarCampos()
    {
      comboBox1.SelectedIndex = -1;
      textBox3.Clear();
      dateTimePicker1.Value = DateTime.Now;
      textBox1.Clear();
      comboBox2.SelectedIndex = -1;
      idSeleccionado = 0;
      button1.Text = "Guardar";
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {

    }
  }
}