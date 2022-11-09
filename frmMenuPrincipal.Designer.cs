namespace GRUPO_C
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SolicitudCancelacionEnvioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EstadoDelServicioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.EstadoDeCuentaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolicitudCancelacionEnvioMenu
            // 
            this.SolicitudCancelacionEnvioMenu.Enabled = false;
            this.SolicitudCancelacionEnvioMenu.Name = "SolicitudCancelacionEnvioMenu";
            this.SolicitudCancelacionEnvioMenu.Size = new System.Drawing.Size(158, 24);
            this.SolicitudCancelacionEnvioMenu.Text = "Solicitud de Servicio";
            this.SolicitudCancelacionEnvioMenu.Click += new System.EventHandler(this.SolicitudCancelacionEnvioMenu_Click);
            // 
            // EstadoDelServicioMenu
            // 
            this.EstadoDelServicioMenu.Enabled = false;
            this.EstadoDelServicioMenu.Name = "EstadoDelServicioMenu";
            this.EstadoDelServicioMenu.Size = new System.Drawing.Size(149, 24);
            this.EstadoDelServicioMenu.Text = "Estado del Servicio";
            this.EstadoDelServicioMenu.Click += new System.EventHandler(this.EstadoServicioMenuItem_Click);
            // 
            // mnsMenu
            // 
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SolicitudCancelacionEnvioMenu,
            this.EstadoDelServicioMenu,
            this.EstadoDeCuentaMenu});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(856, 28);
            this.mnsMenu.TabIndex = 3;
            this.mnsMenu.Text = "Menu";
            // 
            // EstadoDeCuentaMenu
            // 
            this.EstadoDeCuentaMenu.Enabled = false;
            this.EstadoDeCuentaMenu.Name = "EstadoDeCuentaMenu";
            this.EstadoDeCuentaMenu.Size = new System.Drawing.Size(139, 24);
            this.EstadoDeCuentaMenu.Text = "Estado de Cuenta";
            this.EstadoDeCuentaMenu.Click += new System.EventHandler(this.estadoDeCuentaToolStripMenuItem_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(12, 341);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(169, 20);
            this.lblBienvenida.TabIndex = 5;
            this.lblBienvenida.Text = "Bienvenido/a al Sistema";
            this.lblBienvenida.Visible = false;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(333, 221);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(165, 66);
            this.btnIniciarSesion.TabIndex = 7;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(233, 132);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(39, 20);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "CUIL";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(233, 179);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(83, 20);
            this.lblContraseña.TabIndex = 9;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(333, 129);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Ingrese su CUIL";
            this.txtUsuario.Size = new System.Drawing.Size(175, 27);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(333, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Ingrese su Contraseña";
            this.txtPassword.Size = new System.Drawing.Size(175, 27);
            this.txtPassword.TabIndex = 11;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 381);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.mnsMenu);
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "frmMenuPrincipal";
            this.Text = "GRUPO C";
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripMenuItem SolicitudCancelacionEnvioMenu;
        private ToolStripMenuItem EstadoDelServicioMenu;
        private MenuStrip mnsMenu;
        private ToolStripMenuItem EstadoDeCuentaMenu;
        private Label lblBienvenida;
        private Button btnIniciarSesion;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtUsuario;
        private TextBox txtPassword;
    }
}