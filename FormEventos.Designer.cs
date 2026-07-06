namespace Diseño_Trabajo_final
{
    partial class FormEventos
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
      groupBox1 = new GroupBox();
      button3 = new Button();
      button5 = new Button();
      dateTimePicker1 = new DateTimePicker();
      textBox3 = new TextBox();
      button2 = new Button();
      textBox1 = new TextBox();
      button1 = new Button();
      comboBox2 = new ComboBox();
      comboBox1 = new ComboBox();
      EstadoSolicitud = new Label();
      label4 = new Label();
      label3 = new Label();
      label2 = new Label();
      label1 = new Label();
      dataGridView1 = new DataGridView();
      groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
      SuspendLayout();
      // 
      // groupBox1
      // 
      groupBox1.Controls.Add(button3);
      groupBox1.Controls.Add(button5);
      groupBox1.Controls.Add(dateTimePicker1);
      groupBox1.Controls.Add(textBox3);
      groupBox1.Controls.Add(button2);
      groupBox1.Controls.Add(textBox1);
      groupBox1.Controls.Add(button1);
      groupBox1.Controls.Add(comboBox2);
      groupBox1.Controls.Add(comboBox1);
      groupBox1.Controls.Add(EstadoSolicitud);
      groupBox1.Controls.Add(label4);
      groupBox1.Controls.Add(label3);
      groupBox1.Controls.Add(label2);
      groupBox1.Controls.Add(label1);
      groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      groupBox1.Location = new Point(14, 16);
      groupBox1.Margin = new Padding(3, 4, 3, 4);
      groupBox1.Name = "groupBox1";
      groupBox1.Padding = new Padding(3, 4, 3, 4);
      groupBox1.Size = new Size(911, 348);
      groupBox1.TabIndex = 0;
      groupBox1.TabStop = false;
      groupBox1.Text = "Datos del Evento";
      groupBox1.Enter += groupBox1_Enter;
      // 
      // button3
      // 
      button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      button3.Location = new Point(712, 198);
      button3.Margin = new Padding(3, 4, 3, 4);
      button3.Name = "button3";
      button3.Size = new Size(171, 67);
      button3.TabIndex = 14;
      button3.Text = "Limpiar";
      button3.UseVisualStyleBackColor = true;
      button3.Click += button3_Click;
      // 
      // button5
      // 
      button5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      button5.Location = new Point(712, 86);
      button5.Margin = new Padding(3, 4, 3, 4);
      button5.Name = "button5";
      button5.Size = new Size(171, 67);
      button5.TabIndex = 15;
      button5.Text = "Eliminar";
      button5.UseVisualStyleBackColor = true;
      button5.Click += button5_Click;
      // 
      // dateTimePicker1
      // 
      dateTimePicker1.Format = DateTimePickerFormat.Short;
      dateTimePicker1.Location = new Point(85, 160);
      dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
      dateTimePicker1.Name = "dateTimePicker1";
      dateTimePicker1.Size = new Size(142, 34);
      dateTimePicker1.TabIndex = 10;
      dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
      // 
      // textBox3
      // 
      textBox3.Location = new Point(173, 101);
      textBox3.Margin = new Padding(3, 4, 3, 4);
      textBox3.Name = "textBox3";
      textBox3.Size = new Size(266, 34);
      textBox3.TabIndex = 9;
      // 
      // button2
      // 
      button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      button2.Location = new Point(503, 193);
      button2.Margin = new Padding(3, 4, 3, 4);
      button2.Name = "button2";
      button2.Size = new Size(171, 67);
      button2.TabIndex = 13;
      button2.Text = "Editar";
      button2.UseVisualStyleBackColor = true;
      button2.Click += button2_Click;
      // 
      // textBox1
      // 
      textBox1.Location = new Point(85, 213);
      textBox1.Margin = new Padding(3, 4, 3, 4);
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(354, 34);
      textBox1.TabIndex = 7;
      // 
      // button1
      // 
      button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      button1.Location = new Point(503, 86);
      button1.Margin = new Padding(3, 4, 3, 4);
      button1.Name = "button1";
      button1.Size = new Size(171, 67);
      button1.TabIndex = 12;
      button1.Text = "Guardar";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // comboBox2
      // 
      comboBox2.FormattingEnabled = true;
      comboBox2.Location = new Point(192, 287);
      comboBox2.Margin = new Padding(3, 4, 3, 4);
      comboBox2.Name = "comboBox2";
      comboBox2.Size = new Size(122, 36);
      comboBox2.TabIndex = 6;
      comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
      // 
      // comboBox1
      // 
      comboBox1.FormattingEnabled = true;
      comboBox1.Location = new Point(96, 45);
      comboBox1.Margin = new Padding(3, 4, 3, 4);
      comboBox1.Name = "comboBox1";
      comboBox1.Size = new Size(342, 36);
      comboBox1.TabIndex = 5;
      comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
      // 
      // EstadoSolicitud
      // 
      EstadoSolicitud.AutoSize = true;
      EstadoSolicitud.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
      EstadoSolicitud.Location = new Point(7, 285);
      EstadoSolicitud.Name = "EstadoSolicitud";
      EstadoSolicitud.Size = new Size(179, 32);
      EstadoSolicitud.TabIndex = 4;
      EstadoSolicitud.Text = "EstadoSolicitud";
      EstadoSolicitud.Click += label5_Click;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label4.Location = new Point(9, 213);
      label4.Name = "label4";
      label4.Size = new Size(76, 32);
      label4.TabIndex = 3;
      label4.Text = "Lugar";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label3.Location = new Point(7, 157);
      label3.Name = "label3";
      label3.Size = new Size(77, 32);
      label3.TabIndex = 2;
      label3.Text = "Fecha";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label2.Location = new Point(7, 101);
      label2.Name = "label2";
      label2.Size = new Size(176, 32);
      label2.TabIndex = 1;
      label2.Text = "Tipo de Evento";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label1.Location = new Point(7, 41);
      label1.Name = "label1";
      label1.Size = new Size(90, 32);
      label1.TabIndex = 0;
      label1.Text = "Cliente";
      // 
      // dataGridView1
      // 
      dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView1.Location = new Point(12, 381);
      dataGridView1.Name = "dataGridView1";
      dataGridView1.RowHeadersWidth = 51;
      dataGridView1.Size = new Size(984, 188);
      dataGridView1.TabIndex = 16;
      dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
      // 
      // FormEventos
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1010, 592);
      Controls.Add(dataGridView1);
      Controls.Add(groupBox1);
      Margin = new Padding(3, 4, 3, 4);
      Name = "FormEventos";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Gestión de Eventos";
      Load += FormEventos_Load;
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
        private Label EstadoSolicitud;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}