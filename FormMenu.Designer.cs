namespace Diseño_Trabajo_final
{
    partial class FormMenu
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
      panelMenu = new Panel();
      button4 = new Button();
      btnUsers = new Button();
      button3 = new Button();
      button5 = new Button();
      button1 = new Button();
      pictureBox1 = new PictureBox();
      btnFactura = new Button();
      panelMenu.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // panelMenu
      // 
      panelMenu.AutoScrollMargin = new Size(200, 0);
      panelMenu.BackColor = Color.FromArgb(0, 0, 64);
      panelMenu.Controls.Add(button4);
      panelMenu.Controls.Add(button5);
      panelMenu.Controls.Add(btnUsers);
      panelMenu.Controls.Add(button3);
      panelMenu.Controls.Add(btnFactura);
      panelMenu.Controls.Add(button1);
      panelMenu.Location = new Point(0, 0);
      panelMenu.Margin = new Padding(3, 4, 3, 4);
      panelMenu.Name = "panelMenu";
      panelMenu.Size = new Size(229, 944);
      panelMenu.TabIndex = 0;
      panelMenu.Paint += panelMenu_Paint;
      // 
      // button4
      // 
      button4.BackColor = Color.FromArgb(0, 0, 64);
      button4.Dock = DockStyle.Top;
      button4.FlatStyle = FlatStyle.Flat;
      button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
      button4.ForeColor = Color.White;
      button4.Location = new Point(0, 275);
      button4.Margin = new Padding(3, 4, 3, 4);
      button4.Name = "button4";
      button4.Size = new Size(229, 55);
      button4.TabIndex = 5;
      button4.Text = "Salir";
      button4.UseVisualStyleBackColor = false;
      button4.Click += button4_Click;
      // 
      // btnUsers
      // 
      btnUsers.BackColor = Color.FromArgb(0, 0, 64);
      btnUsers.Dock = DockStyle.Top;
      btnUsers.FlatStyle = FlatStyle.Flat;
      btnUsers.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
      btnUsers.ForeColor = Color.White;
      btnUsers.Location = new Point(0, 165);
      btnUsers.Margin = new Padding(3, 4, 3, 4);
      btnUsers.Name = "btnUsers";
      btnUsers.Size = new Size(229, 55);
      btnUsers.TabIndex = 6;
      btnUsers.Text = "Usuarios";
      btnUsers.UseVisualStyleBackColor = false;
      btnUsers.Click += btnUsers_Click;
      // 
      // button3
      // 
      button3.BackColor = Color.FromArgb(0, 0, 64);
      button3.Dock = DockStyle.Top;
      button3.FlatStyle = FlatStyle.Flat;
      button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
      button3.ForeColor = Color.White;
      button3.Location = new Point(0, 110);
      button3.Margin = new Padding(3, 4, 3, 4);
      button3.Name = "button3";
      button3.Size = new Size(229, 55);
      button3.TabIndex = 2;
      button3.Text = "Inventario";
      button3.UseVisualStyleBackColor = false;
      button3.Click += button3_Click;
      // 
      // button5
      // 
      button5.BackColor = Color.FromArgb(0, 0, 64);
      button5.Dock = DockStyle.Top;
      button5.FlatStyle = FlatStyle.Flat;
      button5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
      button5.ForeColor = Color.White;
      button5.Location = new Point(0, 220);
      button5.Margin = new Padding(3, 4, 3, 4);
      button5.Name = "button5";
      button5.Size = new Size(229, 55);
      button5.TabIndex = 4;
      button5.Text = "Eventos";
      button5.UseVisualStyleBackColor = false;
      button5.Click += button5_Click;
      // 
      // button1
      // 
      button1.BackColor = Color.FromArgb(0, 0, 64);
      button1.Dock = DockStyle.Top;
      button1.FlatStyle = FlatStyle.Flat;
      button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
      button1.ForeColor = Color.White;
      button1.Location = new Point(0, 0);
      button1.Margin = new Padding(3, 4, 3, 4);
      button1.Name = "button1";
      button1.Size = new Size(229, 55);
      button1.TabIndex = 0;
      button1.Text = "Clientes";
      button1.UseVisualStyleBackColor = false;
      button1.Click += button1_Click;
      // 
      // pictureBox1
      // 
      pictureBox1.BackColor = Color.Transparent;
      pictureBox1.Dock = DockStyle.Fill;
      pictureBox1.Image = Properties.Resources.ChatGPT_Image_8_abr_2026__22_19_24;
      pictureBox1.Location = new Point(0, 0);
      pictureBox1.Margin = new Padding(0);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(1566, 944);
      pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      pictureBox1.TabIndex = 1;
      pictureBox1.TabStop = false;
      pictureBox1.Click += pictureBox1_Click;
      // 
      // btnFactura
      // 
      btnFactura.BackColor = Color.FromArgb(0, 0, 64);
      btnFactura.Dock = DockStyle.Top;
      btnFactura.FlatStyle = FlatStyle.Flat;
      btnFactura.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
      btnFactura.ForeColor = Color.White;
      btnFactura.Location = new Point(0, 55);
      btnFactura.Margin = new Padding(3, 4, 3, 4);
      btnFactura.Name = "btnFactura";
      btnFactura.Size = new Size(229, 55);
      btnFactura.TabIndex = 7;
      btnFactura.Text = "Facturacion";
      btnFactura.UseVisualStyleBackColor = false;
      btnFactura.Click += btnFactura_Click;
      // 
      // FormMenu
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1566, 944);
      Controls.Add(panelMenu);
      Controls.Add(pictureBox1);
      Margin = new Padding(3, 4, 3, 4);
      Name = "FormMenu";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Gestión de Eventos";
      Load += FormMenu_Load;
      panelMenu.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private Panel panelMenu;
        private Button button3;
        private Button button5;
        private Button button1;
        private Button button4;
        private PictureBox pictureBox1;
    private Button btnUsers;
    private Button btnFactura;
  }
}