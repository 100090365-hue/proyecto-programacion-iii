using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Diseño_Trabajo_final
{
  public partial class FormUsuarios : Form
  {
    private int idSeleccionado = 0;
    public FormUsuarios()
    {
      InitializeComponent();
      btnGuardar.Text = "💾 Guardar";
      btnEditar.Text = "✏️ Editar";
      btnLimpiar.Text = "🧹 Limpiar";
      btnEliminar.Text = "🗑️ Eliminar";
    }

    private void CargarClientes()
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        try
        {
          SqlDataAdapter da = new SqlDataAdapter(
              "SELECT * FROM Usuario", cn);
          DataTable dt = new DataTable();
          da.Fill(dt);

          dataGridView1.DataSource = null;
          dataGridView1.DataSource = dt;


          dataGridView1.ReadOnly = true;
          dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          dataGridView1.MultiSelect = false;
          dataGridView1.AllowUserToAddRows = false;
          dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void LimpiarCampos()
    {
      txtUsers.Clear();
      txtEmail.Clear();
      txtContra.Clear();
      comboRol.Text = "";
      idSeleccionado = 0;
      btnGuardar.Text = "Guardar";
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      //txtUsers.Text = "";
      //txtContra.Text = "";
      //txtEmail.Text = "";
      //comboRol.Text = "";
      LimpiarCampos();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtUsers.Text) ||
                string.IsNullOrWhiteSpace(txtContra.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(comboRol.Text))
      {
        MessageBox.Show("Complete todos los campos.", "Advertencia",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      using (SqlConnection cn = Conexion.GetConectar())
      {
        try
        {
          cn.Open();

          if (idSeleccionado == 0)
          {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Usuario (NombreUsuario, Correo, Clave, Rol) VALUES (@NombreUsuario, @Correo, @Clave, @Rol)", cn);
            cmd.Parameters.AddWithValue("@NombreUsuario", txtUsers.Text.Trim());
            cmd.Parameters.AddWithValue("@Correo", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@Clave", txtContra.Text.Trim());
            cmd.Parameters.AddWithValue("@Rol", comboRol.Text.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Usuario guardado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
            SqlCommand cmd = new SqlCommand(
                "UPDATE Usuario SET NombreUsuario=@NombreUsuario, Correo=@Correo, Rol=@Rol, Clave=@Clave WHERE IdUsuario=@IdUsuario", cn);
            cmd.Parameters.AddWithValue("@NombreUsuario", txtUsers.Text.Trim());
            cmd.Parameters.AddWithValue("@Correo", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@Clave", txtContra.Text.Trim());
            cmd.Parameters.AddWithValue("@Rol", comboRol.Text.Trim());
            cmd.Parameters.AddWithValue("@IdUsuario", idSeleccionado);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Usuario actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }

          CargarClientes();
          LimpiarCampos();
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {

      if (dataGridView1.SelectedRows.Count == 0)
      {
        MessageBox.Show("Haga clic sobre una fila de la tabla para seleccionarla.", "Advertencia",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      DataRowView drv = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
      if (drv == null) return;

      idSeleccionado = Convert.ToInt32(drv["IdUsuario"]);
      txtUsers.Text = drv["NombreUsuario"].ToString();
      txtEmail.Text = drv["Correo"].ToString();
      txtContra.Text = drv["Clave"].ToString();
      comboRol.Text = drv["Rol"].ToString();
      btnGuardar.Text = "Actualizar";
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (dataGridView1.SelectedRows.Count == 0)
      {
        MessageBox.Show("Haga clic sobre una fila de la tabla para seleccionarla.", "Advertencia",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }


      DataRowView drv = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
      if (drv == null) return;

      int id = Convert.ToInt32(drv["IdUsuario"]);
      string nombre = drv["NombreUsuario"].ToString();

      DialogResult confirm = MessageBox.Show(
          $"¿Desea eliminar al Usuario '{nombre}'?",
          "Confirmar eliminación",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      if (confirm == DialogResult.Yes)
      {
        using (SqlConnection cn = Conexion.GetConectar())
        {
          try
          {
            cn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE IdUsuario=@IdUsuario", cn);
            cmd.Parameters.AddWithValue("@IdUsuario", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Usuario eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarClientes();
            LimpiarCampos();
          }
          catch (Exception ex)
          {
            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }

    private void Usuarios_Load(object sender, EventArgs e)
    {
      CargarClientes();
    }
  }
}
