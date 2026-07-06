namespace Diseño_Trabajo_final
{
    partial class FormClientes
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
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      button1 = new Button();
      button2 = new Button();
      button3 = new Button();
      button4 = new Button();
      dataGridView1 = new DataGridView();
      textBox1 = new TextBox();
      textBox2 = new TextBox();
      textBox3 = new TextBox();
      button5 = new Button();
      label4 = new Label();
      pictureBox1 = new PictureBox();
      ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
      label1.Location = new Point(461, 93);
      label1.Name = "label1";
      label1.Size = new Size(118, 37);
      label1.TabIndex = 0;
      label1.Text = "Nombre";
      label1.Click += label1_Click;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
      label2.Location = new Point(461, 167);
      label2.Name = "label2";
      label2.Size = new Size(121, 37);
      label2.TabIndex = 1;
      label2.Text = "Telefono";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
      label3.Location = new Point(461, 245);
      label3.Name = "label3";
      label3.Size = new Size(100, 37);
      label3.TabIndex = 2;
      label3.Text = "Correo";
      // 
      // button1
      // 
      button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      button1.Location = new Point(14, 345);
      button1.Margin = new Padding(3, 4, 3, 4);
      button1.Name = "button1";
      button1.Size = new Size(171, 67);
      button1.TabIndex = 3;
      button1.Text = "Guardar";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // button2
      // 
      button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      button2.Location = new Point(238, 345);
      button2.Margin = new Padding(3, 4, 3, 4);
      button2.Name = "button2";
      button2.Size = new Size(171, 67);
      button2.TabIndex = 4;
      button2.Text = "Editar";
      button2.UseVisualStyleBackColor = true;
      button2.Click += button2_Click;
      // 
      // button3
      // 
      button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      button3.Location = new Point(711, 345);
      button3.Margin = new Padding(3, 4, 3, 4);
      button3.Name = "button3";
      button3.Size = new Size(171, 67);
      button3.TabIndex = 5;
      button3.Text = "Limpiar";
      button3.UseVisualStyleBackColor = true;
      button3.Click += button3_Click;
      // 
      // button4
      // 
      button4.Location = new Point(461, 416);
      button4.Margin = new Padding(3, 4, 3, 4);
      button4.Name = "button4";
      button4.Size = new Size(86, 31);
      button4.TabIndex = 6;
      button4.Text = "Editar";
      button4.UseVisualStyleBackColor = true;
      button4.Visible = false;
      // 
      // dataGridView1
      // 
      dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView1.Dock = DockStyle.Bottom;
      dataGridView1.Location = new Point(0, 420);
      dataGridView1.Margin = new Padding(3, 4, 3, 4);
      dataGridView1.Name = "dataGridView1";
      dataGridView1.RowHeadersWidth = 51;
      dataGridView1.Size = new Size(896, 195);
      dataGridView1.TabIndex = 7;
      dataGridView1.CellContentClick += dataGridView1_CellContentClick;
      // 
      // textBox1
      // 
      textBox1.Location = new Point(574, 105);
      textBox1.Margin = new Padding(3, 4, 3, 4);
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(173, 27);
      textBox1.TabIndex = 8;
      // 
      // textBox2
      // 
      textBox2.Location = new Point(574, 179);
      textBox2.Margin = new Padding(3, 4, 3, 4);
      textBox2.Name = "textBox2";
      textBox2.Size = new Size(173, 27);
      textBox2.TabIndex = 9;
      // 
      // textBox3
      // 
      textBox3.Location = new Point(574, 257);
      textBox3.Margin = new Padding(3, 4, 3, 4);
      textBox3.Name = "textBox3";
      textBox3.Size = new Size(173, 27);
      textBox3.TabIndex = 10;
      // 
      // button5
      // 
      button5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      button5.Location = new Point(461, 345);
      button5.Margin = new Padding(3, 4, 3, 4);
      button5.Name = "button5";
      button5.Size = new Size(171, 67);
      button5.TabIndex = 11;
      button5.Text = "Eliminar";
      button5.UseVisualStyleBackColor = true;
      button5.Click += button5_Click;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.BorderStyle = BorderStyle.Fixed3D;
      label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label4.Location = new Point(313, 12);
      label4.Name = "label4";
      label4.Size = new Size(305, 43);
      label4.TabIndex = 12;
      label4.Text = "DATOS DEL CLIENTE";
      // 
      // pictureBox1
      // 
      pictureBox1.Image = Properties.Resources._4658791;
      pictureBox1.Location = new Point(60, 73);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(291, 239);
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      pictureBox1.TabIndex = 13;
      pictureBox1.TabStop = false;
      // 
      // FormClientes
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(896, 615);
      Controls.Add(pictureBox1);
      Controls.Add(label4);
      Controls.Add(button5);
      Controls.Add(textBox3);
      Controls.Add(textBox2);
      Controls.Add(textBox1);
      Controls.Add(dataGridView1);
      Controls.Add(button4);
      Controls.Add(button3);
      Controls.Add(button2);
      Controls.Add(button1);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Margin = new Padding(3, 4, 3, 4);
      MaximizeBox = false;
      MaximumSize = new Size(914, 662);
      MinimizeBox = false;
      MinimumSize = new Size(914, 662);
      Name = "FormClientes";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Gestión de Clientes";
      Load += FormClientes_Load;
      ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button5;
        private Label label4;
    private PictureBox pictureBox1;
  }
}