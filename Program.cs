using System.Data.SqlClient;

namespace Diseño_Trabajo_final
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      // Verificamos si existe un usuario administrador
      bool existeAdmin = VerificarUsuarioAdmin();

      if (!existeAdmin)
      {
        // Si no hay admin → abrir registro de usuario
        Application.Run(new FormRegistro());
      }
      else
      {
        // Si ya existe admin → abrir login
        Application.Run(new FormLogin());
      }
    }

    private static bool VerificarUsuarioAdmin()
    {
      bool existe = false;

      using (SqlConnection cn = Conexion.GetConectar())
      {
        try
        {
          cn.Open();
          string query = "SELECT COUNT(*) FROM Usuario WHERE Rol = 'Administrador'";

          using (SqlCommand cmd = new SqlCommand(query, cn))
          {
            int count = (int)cmd.ExecuteScalar();
            existe = count > 0;
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error al verificar usuario administrador: " + ex.Message,
              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }

      return existe;

    }
  }
}