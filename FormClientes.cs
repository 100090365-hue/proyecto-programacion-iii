using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Diseño_Trabajo_final.Mantenimientos;

namespace Diseño_Trabajo_final
{
    public partial class FormClientes : Form
    {
        private int idSeleccionado = 0;
        MantCliente cliente = new MantCliente();

        public FormClientes()
        {
            InitializeComponent();
            button1.Text = "💾 Guardar";
            button2.Text = "✏️ Editar";
            button3.Text = "🧹 Limpiar";
            button5.Text = "🗑️ Eliminar";
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {

                var dt = cliente.CargarClientes();

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
        
                cliente.AddUpdate(idSeleccionado, textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim());

                CargarClientes();
                LimpiarCampos();

                //MessageBox.Show("Cliente guardado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Cliente actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            idSeleccionado = Convert.ToInt32(drv["IdCliente"]);
            textBox1.Text = drv["NombreCliente"].ToString();
            textBox2.Text = drv["Telefono"].ToString();
            textBox3.Text = drv["Correo"].ToString();
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

            int id = Convert.ToInt32(drv["IdCliente"]);
            string nombre = drv["NombreCliente"].ToString();

            DialogResult confirm = MessageBox.Show(
                $"¿Desea eliminar al cliente '{nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                cliente.DeleteCliente(id);
                LimpiarCampos();
                CargarClientes();
            }
        }

        private void button3_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            idSeleccionado = 0;
            button1.Text = "Guardar";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}