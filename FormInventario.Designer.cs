using System.Data;

namespace Diseño_Trabajo_final
{
    partial class FormInventario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
      btnGuardar = new Button();
      btnEliminar = new Button();
      btnEditar = new Button();
      button3 = new Button();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      label4 = new Label();
      txtProducto = new TextBox();
      txtCantidad = new TextBox();
      txtPrecio = new TextBox();
      txtCategoria = new TextBox();
      dataGridView1 = new DataGridView();
      pictureBox1 = new PictureBox();
      ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // btnGuardar
      // 
      btnGuardar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      btnGuardar.Location = new Point(88, 316);
      btnGuardar.Margin = new Padding(3, 4, 3, 4);
      btnGuardar.Name = "btnGuardar";
      btnGuardar.Size = new Size(171, 67);
      btnGuardar.TabIndex = 13;
      btnGuardar.Text = "Guardar";
      btnGuardar.UseVisualStyleBackColor = true;
      btnGuardar.Click += btnGuardar_Click;
      // 
      // btnEliminar
      // 
      btnEliminar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      btnEliminar.Location = new Point(806, 316);
      btnEliminar.Margin = new Padding(3, 4, 3, 4);
      btnEliminar.Name = "btnEliminar";
      btnEliminar.Size = new Size(171, 67);
      btnEliminar.TabIndex = 14;
      btnEliminar.Text = "Eliminar";
      btnEliminar.UseVisualStyleBackColor = true;
      btnEliminar.Click += btnEliminar_Click;
      // 
      // btnEditar
      // 
      btnEditar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      btnEditar.Location = new Point(325, 316);
      btnEditar.Margin = new Padding(3, 4, 3, 4);
      btnEditar.Name = "btnEditar";
      btnEditar.Size = new Size(171, 67);
      btnEditar.TabIndex = 16;
      btnEditar.Text = "Editar";
      btnEditar.UseVisualStyleBackColor = true;
      btnEditar.Click += btnEditar_Click;
      // 
      // button3
      // 
      button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      button3.Location = new Point(561, 316);
      button3.Margin = new Padding(3, 4, 3, 4);
      button3.Name = "button3";
      button3.Size = new Size(171, 67);
      button3.TabIndex = 17;
      button3.Text = "Limpiar";
      button3.UseVisualStyleBackColor = true;
      button3.Click += button3_Click;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
      label1.Location = new Point(471, 80);
      label1.Name = "label1";
      label1.Size = new Size(130, 37);
      label1.TabIndex = 18;
      label1.Text = "Producto";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
      label2.Location = new Point(477, 196);
      label2.Name = "label2";
      label2.Size = new Size(93, 37);
      label2.TabIndex = 19;
      label2.Text = "Precio";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
      label3.Location = new Point(474, 142);
      label3.Name = "label3";
      label3.Size = new Size(127, 37);
      label3.TabIndex = 20;
      label3.Text = "Cantidad";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
      label4.Location = new Point(474, 254);
      label4.Name = "label4";
      label4.Size = new Size(160, 37);
      label4.TabIndex = 21;
      label4.Text = "Descripcion";
      // 
      // txtProducto
      // 
      txtProducto.Location = new Point(672, 90);
      txtProducto.Margin = new Padding(3, 4, 3, 4);
      txtProducto.Name = "txtProducto";
      txtProducto.Size = new Size(354, 27);
      txtProducto.TabIndex = 22;
      txtProducto.TextChanged += txtProducto_TextChanged;
      // 
      // txtCantidad
      // 
      txtCantidad.Location = new Point(672, 152);
      txtCantidad.Margin = new Padding(3, 4, 3, 4);
      txtCantidad.Name = "txtCantidad";
      txtCantidad.Size = new Size(354, 27);
      txtCantidad.TabIndex = 23;
      // 
      // txtPrecio
      // 
      txtPrecio.Location = new Point(672, 206);
      txtPrecio.Margin = new Padding(3, 4, 3, 4);
      txtPrecio.Name = "txtPrecio";
      txtPrecio.Size = new Size(354, 27);
      txtPrecio.TabIndex = 24;
      // 
      // txtCategoria
      // 
      txtCategoria.Location = new Point(672, 264);
      txtCategoria.Margin = new Padding(3, 4, 3, 4);
      txtCategoria.Name = "txtCategoria";
      txtCategoria.Size = new Size(354, 27);
      txtCategoria.TabIndex = 25;
      // 
      // dataGridView1
      // 
      dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView1.Dock = DockStyle.Bottom;
      dataGridView1.Location = new Point(0, 409);
      dataGridView1.Margin = new Padding(3, 4, 3, 4);
      dataGridView1.Name = "dataGridView1";
      dataGridView1.RowHeadersWidth = 51;
      dataGridView1.Size = new Size(1071, 195);
      dataGridView1.TabIndex = 26;
      dataGridView1.CellContentClick += dataGridView1_CellContentClick;
      // 
      // pictureBox1
      // 
      pictureBox1.Image = Properties.Resources._4143218;
      pictureBox1.Location = new Point(54, 23);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(344, 268);
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      pictureBox1.TabIndex = 27;
      pictureBox1.TabStop = false;
      // 
      // FormInventario
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1071, 604);
      Controls.Add(pictureBox1);
      Controls.Add(dataGridView1);
      Controls.Add(txtCategoria);
      Controls.Add(txtPrecio);
      Controls.Add(txtCantidad);
      Controls.Add(txtProducto);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(button3);
      Controls.Add(btnEditar);
      Controls.Add(btnEliminar);
      Controls.Add(btnGuardar);
      Name = "FormInventario";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Gestion de Inventario";
      Load += FormInventario_Load;
      ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count == 0)
        {
            MessageBox.Show("Selecciona una fila.", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DataRowView drv = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
        if (drv == null) return;

        // Comprobación sencilla
        if (drv.Row.IsNull("IdArticulo"))
        {
            MessageBox.Show("El registro no tiene Id asignado.", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        idSeleccionado = Convert.ToInt32(drv["IdArticulo"]);

        // Alternativa idiomática con Field<T>
        int? id = drv.Row.Field<int?>("IdArticulo");
        if (!id.HasValue)
        {
            MessageBox.Show("El registro no tiene Id asignado.", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        idSeleccionado = id.Value;

        txtProducto.Text = drv["NombreArticulo"].ToString();
        txtCantidad.Text = drv["CantidadDisponible"].ToString();
        txtPrecio.Text = drv["PrecioAlquiler"].ToString();
        txtCategoria.Text = drv["Descripcion"].ToString();

        btnGuardar.Text = "Actualizar";
}

        // ✅ TODOS LOS MÉTODOS VACÍOS — sin throw, sin crash
        // Los métodos reales están en FormInventario.cs

        #endregion

        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private TextBox txtCategoria;
        private DataGridView dataGridView1;
    private PictureBox pictureBox1;
  }
}