namespace Diseño_Trabajo_final
{
  partial class FormFacturas
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      dataGridView1 = new DataGridView();
      comboMetodoPago = new ComboBox();
      comboEvento = new ComboBox();
      comboCliente = new ComboBox();
      txtMontoTotal = new TextBox();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      label6 = new Label();
      label7 = new Label();
      label9 = new Label();
      comboArticu = new ComboBox();
      label8 = new Label();
      txtCantidad = new TextBox();
      btnAddArticulo = new Button();
      button1 = new Button();
      txtMontoPorArt = new TextBox();
      label4 = new Label();
      pictureBox1 = new PictureBox();
      button2 = new Button();
      button3 = new Button();
      button5 = new Button();
      btnExportarExcel = new Button();
      ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // dataGridView1
      // 
      dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView1.Dock = DockStyle.Bottom;
      dataGridView1.Location = new Point(0, 447);
      dataGridView1.Margin = new Padding(3, 4, 3, 4);
      dataGridView1.Name = "dataGridView1";
      dataGridView1.RowHeadersWidth = 51;
      dataGridView1.Size = new Size(1068, 234);
      dataGridView1.TabIndex = 36;
      // 
      // comboMetodoPago
      // 
      comboMetodoPago.Font = new Font("Segoe UI", 12F);
      comboMetodoPago.FormattingEnabled = true;
      comboMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
      comboMetodoPago.Location = new Point(767, 199);
      comboMetodoPago.Name = "comboMetodoPago";
      comboMetodoPago.Size = new Size(253, 36);
      comboMetodoPago.TabIndex = 39;
      // 
      // comboEvento
      // 
      comboEvento.Font = new Font("Segoe UI", 12F);
      comboEvento.FormattingEnabled = true;
      comboEvento.Location = new Point(767, 148);
      comboEvento.Name = "comboEvento";
      comboEvento.Size = new Size(253, 36);
      comboEvento.TabIndex = 38;
      comboEvento.SelectedIndexChanged += comboEvento_SelectedIndexChanged;
      // 
      // comboCliente
      // 
      comboCliente.Font = new Font("Segoe UI", 12F);
      comboCliente.FormattingEnabled = true;
      comboCliente.Location = new Point(767, 95);
      comboCliente.Name = "comboCliente";
      comboCliente.Size = new Size(253, 36);
      comboCliente.TabIndex = 37;
      comboCliente.SelectedIndexChanged += comboCliente_SelectedIndexChanged;
      // 
      // txtMontoTotal
      // 
      txtMontoTotal.Enabled = false;
      txtMontoTotal.Font = new Font("Segoe UI", 12F);
      txtMontoTotal.Location = new Point(767, 252);
      txtMontoTotal.Name = "txtMontoTotal";
      txtMontoTotal.Size = new Size(253, 34);
      txtMontoTotal.TabIndex = 42;
      txtMontoTotal.TextChanged += txtMontoTotal_TextChanged;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label1.Location = new Point(678, 98);
      label1.Name = "label1";
      label1.Size = new Size(83, 28);
      label1.TabIndex = 43;
      label1.Text = "Cliente:";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label2.Location = new Point(678, 151);
      label2.Name = "label2";
      label2.Size = new Size(82, 28);
      label2.TabIndex = 44;
      label2.Text = "Evento:";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label3.Location = new Point(697, 202);
      label3.Name = "label3";
      label3.Size = new Size(64, 28);
      label3.TabIndex = 45;
      label3.Text = "Pago:";
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label6.Location = new Point(697, 255);
      label6.Name = "label6";
      label6.Size = new Size(64, 28);
      label6.TabIndex = 48;
      label6.Text = "Total:";
      // 
      // label7
      // 
      label7.AutoSize = true;
      label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label7.Location = new Point(409, 9);
      label7.Name = "label7";
      label7.Size = new Size(168, 38);
      label7.TabIndex = 49;
      label7.Text = "Facturación";
      // 
      // label9
      // 
      label9.AutoSize = true;
      label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label9.Location = new Point(307, 101);
      label9.Name = "label9";
      label9.Size = new Size(94, 28);
      label9.TabIndex = 52;
      label9.Text = "Articulo:";
      // 
      // comboArticu
      // 
      comboArticu.Font = new Font("Segoe UI", 12F);
      comboArticu.FormattingEnabled = true;
      comboArticu.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia" });
      comboArticu.Location = new Point(407, 98);
      comboArticu.Name = "comboArticu";
      comboArticu.Size = new Size(253, 36);
      comboArticu.TabIndex = 50;
      comboArticu.SelectedIndexChanged += comboArticu_SelectedIndexChanged;
      // 
      // label8
      // 
      label8.AutoSize = true;
      label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label8.Location = new Point(300, 154);
      label8.Name = "label8";
      label8.Size = new Size(101, 28);
      label8.TabIndex = 54;
      label8.Text = "Cantidad:";
      // 
      // txtCantidad
      // 
      txtCantidad.Font = new Font("Segoe UI", 12F);
      txtCantidad.Location = new Point(407, 151);
      txtCantidad.Name = "txtCantidad";
      txtCantidad.Size = new Size(253, 34);
      txtCantidad.TabIndex = 55;
      txtCantidad.TextChanged += txtCantidad_TextChanged;
      // 
      // btnAddArticulo
      // 
      btnAddArticulo.Cursor = Cursors.Hand;
      btnAddArticulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      btnAddArticulo.Location = new Point(426, 252);
      btnAddArticulo.Name = "btnAddArticulo";
      btnAddArticulo.Size = new Size(180, 53);
      btnAddArticulo.TabIndex = 56;
      btnAddArticulo.Text = "Agregar";
      btnAddArticulo.UseVisualStyleBackColor = true;
      btnAddArticulo.Click += btnAddArticulo_Click;
      // 
      // button1
      // 
      button1.Cursor = Cursors.Hand;
      button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      button1.Location = new Point(798, 301);
      button1.Name = "button1";
      button1.Size = new Size(180, 53);
      button1.TabIndex = 57;
      button1.Text = "Facturar";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // txtMontoPorArt
      // 
      txtMontoPorArt.Enabled = false;
      txtMontoPorArt.Font = new Font("Segoe UI", 12F);
      txtMontoPorArt.Location = new Point(407, 199);
      txtMontoPorArt.Name = "txtMontoPorArt";
      txtMontoPorArt.Size = new Size(253, 34);
      txtMontoPorArt.TabIndex = 59;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      label4.Location = new Point(321, 202);
      label4.Name = "label4";
      label4.Size = new Size(80, 28);
      label4.TabIndex = 58;
      label4.Text = "Monto:";
      // 
      // pictureBox1
      // 
      pictureBox1.Image = Properties.Resources.requisitos_ingreso_pregrado1;
      pictureBox1.Location = new Point(12, 60);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(282, 294);
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      pictureBox1.TabIndex = 60;
      pictureBox1.TabStop = false;
      // 
      // button2
      // 
      button2.Cursor = Cursors.Hand;
      button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      button2.Location = new Point(221, 377);
      button2.Name = "button2";
      button2.Size = new Size(180, 53);
      button2.TabIndex = 61;
      button2.Text = "Editar";
      button2.UseVisualStyleBackColor = true;
      button2.Click += button2_Click;
      // 
      // button3
      // 
      button3.Cursor = Cursors.Hand;
      button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      button3.Location = new Point(447, 377);
      button3.Name = "button3";
      button3.Size = new Size(180, 53);
      button3.TabIndex = 62;
      button3.Text = "Limpiar";
      button3.UseVisualStyleBackColor = true;
      button3.Click += button3_Click;
      // 
      // button5
      // 
      button5.Cursor = Cursors.Hand;
      button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      button5.Location = new Point(667, 377);
      button5.Name = "button5";
      button5.Size = new Size(180, 53);
      button5.TabIndex = 64;
      button5.Text = "E. Articulo";
      button5.UseVisualStyleBackColor = true;
      button5.Click += button5_Click;
      // 
      // btnExportarExcel
      // 
      btnExportarExcel.Cursor = Cursors.Hand;
      btnExportarExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      btnExportarExcel.Location = new Point(877, 377);
      btnExportarExcel.Name = "btnExportarExcel";
      btnExportarExcel.Size = new Size(180, 53);
      btnExportarExcel.TabIndex = 65;
      btnExportarExcel.Text = "Excel";
      btnExportarExcel.UseVisualStyleBackColor = true;
      btnExportarExcel.Click += btnExportarExcel_Click;
      // 
      // FormFacturas
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1068, 681);
      Controls.Add(btnExportarExcel);
      Controls.Add(button5);
      Controls.Add(button3);
      Controls.Add(button2);
      Controls.Add(pictureBox1);
      Controls.Add(txtMontoPorArt);
      Controls.Add(label4);
      Controls.Add(button1);
      Controls.Add(btnAddArticulo);
      Controls.Add(txtCantidad);
      Controls.Add(label8);
      Controls.Add(label9);
      Controls.Add(comboArticu);
      Controls.Add(label7);
      Controls.Add(label6);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(txtMontoTotal);
      Controls.Add(comboMetodoPago);
      Controls.Add(comboEvento);
      Controls.Add(comboCliente);
      Controls.Add(dataGridView1);
      MaximizeBox = false;
      MaximumSize = new Size(1086, 728);
      MinimizeBox = false;
      MinimumSize = new Size(1086, 728);
      Name = "FormFacturas";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "FormFacturas";
      Load += FormFacturas_Load;
      ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private DataGridView dataGridView1;
    private ComboBox comboMetodoPago;
    private ComboBox comboEvento;
    private ComboBox comboCliente;
    private TextBox txtMontoTotal;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label6;
    private Label label7;
    private Label label9;
    private ComboBox comboArticu;
    private Label label8;
    private TextBox txtCantidad;
    private Button btnAddArticulo;
    private Button button1;
    private TextBox txtMontoPorArt;
    private Label label4;
    private PictureBox pictureBox1;
    private Button button2;
    private Button button3;
    private Button button5;
    private Button btnExportarExcel;
  }
}