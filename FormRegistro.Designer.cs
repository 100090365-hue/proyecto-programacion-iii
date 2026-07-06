namespace Diseño_Trabajo_final
{
  partial class FormRegistro
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
      btnRegistrar = new Button();
      btnCancelar = new Button();
      txtNUser = new TextBox();
      txtCorreo = new TextBox();
      txtContra = new TextBox();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      pictureBox1 = new PictureBox();
      label5 = new Label();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // btnRegistrar
      // 
      btnRegistrar.Cursor = Cursors.Hand;
      btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      btnRegistrar.Location = new Point(341, 302);
      btnRegistrar.Name = "btnRegistrar";
      btnRegistrar.Size = new Size(150, 73);
      btnRegistrar.TabIndex = 4;
      btnRegistrar.Text = "Registrar";
      btnRegistrar.UseVisualStyleBackColor = true;
      btnRegistrar.Click += btnRegistrar_Click;
      // 
      // btnCancelar
      // 
      btnCancelar.Cursor = Cursors.Hand;
      btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
      btnCancelar.ForeColor = Color.DarkRed;
      btnCancelar.Location = new Point(519, 302);
      btnCancelar.Name = "btnCancelar";
      btnCancelar.Size = new Size(150, 73);
      btnCancelar.TabIndex = 5;
      btnCancelar.Text = "Cancelar";
      btnCancelar.UseVisualStyleBackColor = true;
      btnCancelar.Click += button2_Click;
      // 
      // txtNUser
      // 
      txtNUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      txtNUser.Location = new Point(341, 99);
      txtNUser.Name = "txtNUser";
      txtNUser.Size = new Size(328, 34);
      txtNUser.TabIndex = 0;
      // 
      // txtCorreo
      // 
      txtCorreo.Font = new Font("Segoe UI", 12F);
      txtCorreo.Location = new Point(341, 170);
      txtCorreo.Name = "txtCorreo";
      txtCorreo.Size = new Size(328, 34);
      txtCorreo.TabIndex = 1;
      // 
      // txtContra
      // 
      txtContra.Font = new Font("Segoe UI", 12F);
      txtContra.Location = new Point(341, 240);
      txtContra.Name = "txtContra";
      txtContra.PasswordChar = '*';
      txtContra.Size = new Size(328, 34);
      txtContra.TabIndex = 2;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label1.Location = new Point(341, 76);
      label1.Name = "label1";
      label1.Size = new Size(63, 20);
      label1.TabIndex = 6;
      label1.Text = "Usuario";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label2.Location = new Point(341, 147);
      label2.Name = "label2";
      label2.Size = new Size(56, 20);
      label2.TabIndex = 7;
      label2.Text = "Correo";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label3.Location = new Point(341, 217);
      label3.Name = "label3";
      label3.Size = new Size(88, 20);
      label3.TabIndex = 8;
      label3.Text = "Contraseña";
      // 
      // pictureBox1
      // 
      pictureBox1.Image = Properties.Resources._4658791;
      pictureBox1.Location = new Point(12, 76);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(312, 299);
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      pictureBox1.TabIndex = 10;
      pictureBox1.TabStop = false;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label5.Location = new Point(227, 20);
      label5.Name = "label5";
      label5.Size = new Size(273, 38);
      label5.TabIndex = 11;
      label5.Text = "Registro de Usuario";
      // 
      // FormRegistro
      // 
      AcceptButton = btnRegistrar;
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = btnCancelar;
      ClientSize = new Size(686, 398);
      ControlBox = false;
      Controls.Add(label5);
      Controls.Add(pictureBox1);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(txtContra);
      Controls.Add(txtCorreo);
      Controls.Add(txtNUser);
      Controls.Add(btnCancelar);
      Controls.Add(btnRegistrar);
      FormBorderStyle = FormBorderStyle.None;
      Name = "FormRegistro";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Registro de Usuario";
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btnRegistrar;
    private Button btnCancelar;
    private TextBox txtNUser;
    private TextBox txtCorreo;
    private TextBox txtContra;
    private Label label1;
    private Label label2;
    private Label label3;
    private PictureBox pictureBox1;
    private Label label5;
  }
}