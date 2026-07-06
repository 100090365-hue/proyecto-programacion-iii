using Diseño_Trabajo_final.Mantenimientos;
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

namespace Diseño_Trabajo_final
{
  public partial class FormLogin : Form
  {

    MantLogin mantLogin = new MantLogin();

    public FormLogin()
    {
      InitializeComponent();
      txtUsuario.KeyDown += TxtUsuario_KeyDown;
      btnEntrar.Text = "🔑 Entrar";
      btnCancel.Text = "❌ Cancelar";
    }

    private void TxtUsuario_KeyDown(object? sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        txtContra.Focus();
        e.Handled = true;
        e.SuppressKeyPress = true; // Evita que se dispare el AcceptButton de forma prematura
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnEntrar_Click(object sender, EventArgs e)
    {
      string usuario = txtUsuario.Text.Trim();
      string clave = txtContra.Text;

      // 1. Validar que ambos campos estén llenos
      if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
      {
        MessageBox.Show("Por favor, ingrese tanto el usuario como la clave.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return; // Detiene la ejecución y mantiene la ventana abierta
      }

      try
      {
        // 2. Consultar base de datos
        string? rol = mantLogin.LoginData(usuario, clave);

        if (rol != null)
        {
          // Login exitoso -> mostrar menú principal
          var main = new FormMenu(rol);
          this.Hide();
          main.ShowDialog();
          this.Close();
        }
        else
        {
          // Login fallido -> mensaje de error y mantener ventana
          MessageBox.Show("Usuario o clave incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
          txtContra.Clear();
          txtContra.Focus();
        }
      }
      catch (Exception ex)
      {
        // Error de base de datos u otro tipo -> mostrar error y mantener ventana
        MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void FormLogin_Load(object sender, EventArgs e)
    {

    }
  }
}
