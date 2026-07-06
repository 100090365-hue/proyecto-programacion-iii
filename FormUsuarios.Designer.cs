namespace Diseño_Trabajo_final
{
  partial class FormUsuarios
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
      dataGridView1 = new DataGridView();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      btnGuardar = new Button();
      btnEditar = new Button();
      btnLimpiar = new Button();
      txtUsers = new TextBox();
      txtEmail = new TextBox();
      txtContra = new TextBox();
      btnEliminar = new Button();
      label4 = new Label();
      pictureBox1 = new PictureBox();
      label5 = new Label();
      comboRol = new ComboBox();
      ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // dataGridView1
      // 
      dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView1.Dock = DockStyle.Bottom;
      dataGridView1.Location = new Point(0, 441);
      dataGridView1.Margin = new Padding(3, 4, 3, 4);
      dataGridView1.Name = "dataGridView1";
      dataGridView1.RowHeadersWidth = 51;
      dataGridView1.Size = new Size(994, 234);
      dataGridView1.TabIndex = 8;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
      label1.Location = new Point(445, 52);
      label1.Name = "label1";
      label1.Size = new Size(118, 37);
      label1.TabIndex = 13;
      label1.Text = "Usuario:";
      label1.Click += label1_Click;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
      label2.Location = new Point(456, 126);
      label2.Name = "label2";
      label2.Size = new Size(107, 37);
      label2.TabIndex = 14;
      label2.Text = "Correo:";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
      label3.Location = new Point(400, 204);
      label3.Name = "label3";
      label3.Size = new Size(163, 37);
      label3.TabIndex = 15;
      label3.Text = "Contraseña:";
      // 
      // btnGuardar
      // 
      btnGuardar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      btnGuardar.Location = new Point(106, 366);
      btnGuardar.Margin = new Padding(3, 4, 3, 4);
      btnGuardar.Name = "btnGuardar";
      btnGuardar.Size = new Size(171, 67);
      btnGuardar.TabIndex = 4;
      btnGuardar.Text = "Guardar";
      btnGuardar.UseVisualStyleBackColor = true;
      btnGuardar.Click += btnGuardar_Click;
      // 
      // btnEditar
      // 
      btnEditar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      btnEditar.Location = new Point(304, 366);
      btnEditar.Margin = new Padding(3, 4, 3, 4);
      btnEditar.Name = "btnEditar";
      btnEditar.Size = new Size(171, 67);
      btnEditar.TabIndex = 5;
      btnEditar.Text = "Editar";
      btnEditar.UseVisualStyleBackColor = true;
      btnEditar.Click += btnEditar_Click;
      // 
      // btnLimpiar
      // 
      btnLimpiar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      btnLimpiar.Location = new Point(694, 366);
      btnLimpiar.Margin = new Padding(3, 4, 3, 4);
      btnLimpiar.Name = "btnLimpiar";
      btnLimpiar.Size = new Size(171, 67);
      btnLimpiar.TabIndex = 7;
      btnLimpiar.Text = "Limpiar";
      btnLimpiar.UseVisualStyleBackColor = true;
      btnLimpiar.Click += btnLimpiar_Click;
      // 
      // txtUsers
      // 
      txtUsers.Font = new Font("Segoe UI", 12F);
      txtUsers.Location = new Point(581, 55);
      txtUsers.Margin = new Padding(3, 4, 3, 4);
      txtUsers.Name = "txtUsers";
      txtUsers.Size = new Size(328, 34);
      txtUsers.TabIndex = 0;
      // 
      // txtEmail
      // 
      txtEmail.Font = new Font("Segoe UI", 12F);
      txtEmail.Location = new Point(581, 129);
      txtEmail.Margin = new Padding(3, 4, 3, 4);
      txtEmail.Name = "txtEmail";
      txtEmail.Size = new Size(328, 34);
      txtEmail.TabIndex = 1;
      // 
      // txtContra
      // 
      txtContra.Font = new Font("Segoe UI", 12F);
      txtContra.Location = new Point(581, 207);
      txtContra.Margin = new Padding(3, 4, 3, 4);
      txtContra.Name = "txtContra";
      txtContra.PasswordChar = '*';
      txtContra.Size = new Size(328, 34);
      txtContra.TabIndex = 2;
      // 
      // btnEliminar
      // 
      btnEliminar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
      btnEliminar.Location = new Point(500, 366);
      btnEliminar.Margin = new Padding(3, 4, 3, 4);
      btnEliminar.Name = "btnEliminar";
      btnEliminar.Size = new Size(171, 67);
      btnEliminar.TabIndex = 6;
      btnEliminar.Text = "Eliminar";
      btnEliminar.UseVisualStyleBackColor = true;
      btnEliminar.Click += btnEliminar_Click;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.BorderStyle = BorderStyle.Fixed3D;
      label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label4.Location = new Point(372, 9);
      label4.Name = "label4";
      label4.Size = new Size(141, 43);
      label4.TabIndex = 25;
      label4.Text = "Usuarios";
      // 
      // pictureBox1
      // 
      pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
      pictureBox1.Location = new Point(12, 52);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(350, 296);
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      pictureBox1.TabIndex = 26;
      pictureBox1.TabStop = false;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
      label5.Location = new Point(500, 289);
      label5.Name = "label5";
      label5.Size = new Size(63, 37);
      label5.TabIndex = 27;
      label5.Text = "Rol:";
      // 
      // comboRol
      // 
      comboRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      comboRol.FormattingEnabled = true;
      comboRol.Items.AddRange(new object[] { "Administrador", "Representante" });
      comboRol.Location = new Point(581, 292);
      comboRol.Name = "comboRol";
      comboRol.Size = new Size(328, 36);
      comboRol.TabIndex = 3;
      // 
      // FormUsuarios
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(994, 675);
      Controls.Add(comboRol);
      Controls.Add(label5);
      Controls.Add(pictureBox1);
      Controls.Add(label4);
      Controls.Add(btnEliminar);
      Controls.Add(txtContra);
      Controls.Add(txtEmail);
      Controls.Add(txtUsers);
      Controls.Add(dataGridView1);
      Controls.Add(btnLimpiar);
      Controls.Add(btnEditar);
      Controls.Add(btnGuardar);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormUsuarios";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Usuarios";
      Load += Usuarios_Load;
      ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private DataGridView dataGridView1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Button btnGuardar;
    private Button btnEditar;
    private Button btnLimpiar;
    private TextBox txtUsers;
    private TextBox txtEmail;
    private TextBox txtContra;
    private Button btnEliminar;
    private Label label4;
    private PictureBox pictureBox1;
    private Label label5;
    private ComboBox comboRol;
  }
}