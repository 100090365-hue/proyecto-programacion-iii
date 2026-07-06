using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Diseño_Trabajo_final.Mantenimientos;

namespace Diseño_Trabajo_final
{
  public partial class FormMenu : Form
  {
    private Form formActivo;
    private object panelContenido;
    private string rolUsuario;
    MantForm MantForm = new MantForm();

    private void ConfigurarMenu()
    {
      if (rolUsuario == "Representante")
      {
        // Ocultar opciones que no debe ver

        button3.Visible = false;
        btnUsers.Visible = false;

      }
      else if (rolUsuario == "Admin")
      {
        // Mostrar todo
        button1.Visible = true;
        button5.Visible = true;
        button3.Visible = true;
        btnUsers.Visible = true;
        button4.Visible = true;
      }
    }

    public FormMenu(string rol)
    {
      InitializeComponent();
      ResaltarBoton(button1);
      rolUsuario = rol;
      ConfigurarMenu();

      // Agregar iconos a los botones del menú lateral
      button1.Text = "👥 Clientes";
      btnFactura.Text = "🧾 Facturacion";
      button3.Text = "📦 Inventario";
      btnUsers.Text = "👤 Usuarios";
      button5.Text = "📅 Eventos";
      button4.Text = "🚪 Salir";
    }

    // -------------------------------------------------------
    // Abre el formulario nuevo y cierra el anterior
    // -------------------------------------------------------
    //private void abrirformulario(form nuevo)
    //{
    //  formactivo?.close();
    //  formactivo = nuevo;
    //  nuevo.formclosed += (s, e) => formactivo = null;
    //  nuevo.show();
    //}

    private void ResaltarBoton(Button activo)
    {
      foreach (Control c in panelMenu.Controls)
        if (c is Button b)
          b.BackColor = Color.FromArgb(0, 0, 64);

      activo.BackColor = Color.FromArgb(30, 30, 120);
    }

    // -------------------------------------------------------
    // CLIENTES — button1
    // -------------------------------------------------------
    private void button1_Click(object sender, EventArgs e)
    {
      ResaltarBoton(button1);
      MantForm.AbrirFormulario(new FormClientes());
    }

    // -------------------------------------------------------
    // EVENTOS — button5
    // -------------------------------------------------------
    private void button5_Click(object sender, EventArgs e)
    {
      ResaltarBoton(button5);
      MantForm.AbrirFormulario(new FormEventos());
    }

    // -------------------------------------------------------
    // INVENTARIO — button3
    // -------------------------------------------------------
    private void button3_Click(object sender, EventArgs e)
    {
      ResaltarBoton(button3);
      MantForm.AbrirFormulario(new FormInventario());
    }

    // -------------------------------------------------------
    // DETALLE EVENTO — button2
    // -------------------------------------------------------
    private void button2_Click(object sender, EventArgs e)
    {
      //ResaltarBoton(button2_Click);
      MessageBox.Show("Módulo de Detalle de Evento en construcción.", "Información",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // -------------------------------------------------------
    // SALIR — button4
    // -------------------------------------------------------
    private void button4_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show(
          "¿Desea salir del sistema?", "Confirmar salida",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == DialogResult.Yes)
        Application.Exit();
    }

    // -------------------------------------------------------
    // AL CARGAR EL MENÚ — verifica conexión a la BD
    // -------------------------------------------------------
    private void FormMenu_Load(object sender, EventArgs e)
    {
      using (SqlConnection cn = Conexion.GetConectar())
      {
        try
        {
          cn.Open();

        }
        catch (Exception ex)
        {
          MessageBox.Show("Error de conexión: " + ex.Message, "Error de conexión",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void btnUsers_Click(object sender, EventArgs e)
    {
      ResaltarBoton(btnUsers);
      MantForm.AbrirFormulario(new FormUsuarios());
    }

    private void panelMenu_Paint(object sender, PaintEventArgs e)
    {

    }

    private void btnFactura_Click(object sender, EventArgs e)
    {
      ResaltarBoton(btnFactura);
      MantForm.AbrirFormulario(new FormFacturas());
    }
  }
}