using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Diseño_Trabajo_final.Mantenimientos;

namespace Diseño_Trabajo_final
{
    public partial class FormInventario : Form
    {
        private int idSeleccionado = 0;
        MantInventario mantInventario = new MantInventario();

        public FormInventario()
        {
            InitializeComponent();
            btnGuardar.Text = "💾 Guardar";
            btnEditar.Text = "✏️ Editar";
            button3.Text = "🧹 Limpiar";
            btnEliminar.Text = "🗑️ Eliminar";
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void CargarInventario()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = mantInventario.CargarInventario();

                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Advertencia",
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
                        mantInventario.AddUpdate(idSeleccionado, txtProducto.Text.Trim(), txtCategoria.Text.Trim(), cantidad, precio);
                        MessageBox.Show("Producto guardado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        mantInventario.AddUpdate(idSeleccionado, txtProducto.Text.Trim(), txtCategoria.Text.Trim(), cantidad, precio);
                        MessageBox.Show("Producto actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    CargarInventario();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int GetIdSeleccionado1()
        {
            return idSeleccionado;
        }

        private void btnEditar_Click(object sender, EventArgs e, int idSeleccionado1)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Haga clic sobre una fila de la tabla para seleccionarla.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataRowView drv = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
            if (drv == null) return;
            idSeleccionado1 = Convert.ToInt32(drv["IdProducto"]);
            txtProducto.Text = drv["Producto"].ToString();
            txtCantidad.Text = drv["Cantidad"].ToString();
            txtPrecio.Text = drv["Precio"].ToString();
            txtCategoria.Text = drv["Descripcion"].ToString();
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


            if (drv.Row.IsNull("IdArticulo") || !int.TryParse(drv["IdArticulo"]?.ToString(), out int id))
            {
                MessageBox.Show("El registro seleccionado no tiene un Id válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string producto = drv.Row.IsNull("NombreArticulo") ? "<sin nombre>" : drv["NombreArticulo"].ToString();

            DialogResult confirm = MessageBox.Show(
                $"¿Desea eliminar '{producto}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    mantInventario.DeleteInventario(id);
                    MessageBox.Show("Articulo eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarInventario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            txtProducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtCategoria.Clear();
            idSeleccionado = 0;
            btnGuardar.Text = "Guardar";
            txtProducto.Focus();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}