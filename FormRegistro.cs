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

namespace Diseño_Trabajo_final
{
  public partial class FormRegistro : Form
  {
    public FormRegistro()
    {
      InitializeComponent();
      btnRegistrar.Text = "👤 Registrar";
      btnCancelar.Text = "❌ Cancelar";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
    //  if (string.IsNullOrWhiteSpace(textBox1.Text) ||
    //string.IsNullOrWhiteSpace(textBox2.Text) ||
    //string.IsNullOrWhiteSpace(textBox3.Text))
    //  {
    //    MessageBox.Show("Complete todos los campos.", "Advertencia",
    //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //    return;
    //  }

      using (SqlConnection cn = Conexion.GetConectar())
      {
        try
        {
          cn.Open();

          if (txtNUser.Text == "" && txtContra.Text == "")
          {
            MessageBox.Show("Los campos Usuario y Contraseña son requeridos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
            SqlCommand cmd = new SqlCommand(
               "INSERT INTO Usuario(NombreUsuario, Correo, Clave, Rol) VALUES(@NombreUsuario, @Correo, @Clave, @Rol)", cn);
            cmd.Parameters.AddWithValue("@NombreUsuario", txtNUser.Text.Trim());
            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());
            cmd.Parameters.AddWithValue("@Clave", txtContra.Text.Trim());
            cmd.Parameters.AddWithValue("@Rol", "Administrador");

            cmd.ExecuteNonQuery();
            MessageBox.Show("El Usuario fue registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var main = new FormMenu("Admin");
            this.Hide();
            main.ShowDialog();
            this.Close();
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
  }
}
