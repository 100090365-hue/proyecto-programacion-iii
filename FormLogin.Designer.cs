namespace Diseño_Trabajo_final
{
  partial class FormLogin
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
      btnEntrar = new Button();
      btnCancel = new Button();
      txtUsuario = new TextBox();
      txtContra = new TextBox();
      labelNUsuario = new Label();
      labelContrase = new Label();
      label1 = new Label();
      pictureBox1 = new PictureBox();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // btnEntrar
      // 
      resources.ApplyResources(btnEntrar, "btnEntrar");
      btnEntrar.Name = "btnEntrar";
      btnEntrar.UseVisualStyleBackColor = true;
      btnEntrar.Click += btnEntrar_Click;
      // 
      // btnCancel
      // 
      btnCancel.BackColor = SystemColors.Control;
      btnCancel.Cursor = Cursors.Hand;
      resources.ApplyResources(btnCancel, "btnCancel");
      btnCancel.ForeColor = Color.DarkRed;
      btnCancel.Name = "btnCancel";
      btnCancel.UseVisualStyleBackColor = false;
      btnCancel.Click += btnCancel_Click;
      // 
      // txtUsuario
      // 
      resources.ApplyResources(txtUsuario, "txtUsuario");
      txtUsuario.Name = "txtUsuario";
      // 
      // txtContra
      // 
      resources.ApplyResources(txtContra, "txtContra");
      txtContra.Name = "txtContra";
      // 
      // labelNUsuario
      // 
      resources.ApplyResources(labelNUsuario, "labelNUsuario");
      labelNUsuario.Name = "labelNUsuario";
      // 
      // labelContrase
      // 
      resources.ApplyResources(labelContrase, "labelContrase");
      labelContrase.Name = "labelContrase";
      // 
      // label1
      // 
      resources.ApplyResources(label1, "label1");
      label1.Name = "label1";
      // 
      // pictureBox1
      // 
      pictureBox1.Image = Properties.Resources.Login;
      resources.ApplyResources(pictureBox1, "pictureBox1");
      pictureBox1.Name = "pictureBox1";
      pictureBox1.TabStop = false;
      // 
      // FormLogin
      // 
      AcceptButton = btnEntrar;
      resources.ApplyResources(this, "$this");
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = btnCancel;
      Controls.Add(pictureBox1);
      Controls.Add(label1);
      Controls.Add(labelContrase);
      Controls.Add(labelNUsuario);
      Controls.Add(txtContra);
      Controls.Add(txtUsuario);
      Controls.Add(btnCancel);
      Controls.Add(btnEntrar);
      FormBorderStyle = FormBorderStyle.None;
      KeyPreview = true;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormLogin";
      Load += FormLogin_Load;
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btnEntrar;
    private Button btnCancel;
    private TextBox txtUsuario;
    private TextBox txtContra;
    private Label labelNUsuario;
    private Label labelContrase;
    private Label label1;
    private PictureBox pictureBox1;
  }
}