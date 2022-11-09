namespace GRUPO_C.formularios
{
    partial class frmEstadoServicio
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
            this.lblIngreseNumeroSol = new System.Windows.Forms.Label();
            this.txtIngreseNumSol = new System.Windows.Forms.TextBox();
            this.btnConsultarEstado = new System.Windows.Forms.Button();
            this.lblComentario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIngreseNumeroSol
            // 
            this.lblIngreseNumeroSol.AutoSize = true;
            this.lblIngreseNumeroSol.Location = new System.Drawing.Point(282, 9);
            this.lblIngreseNumeroSol.Name = "lblIngreseNumeroSol";
            this.lblIngreseNumeroSol.Size = new System.Drawing.Size(189, 20);
            this.lblIngreseNumeroSol.TabIndex = 0;
            this.lblIngreseNumeroSol.Text = "Ingrese el número de envío";
            // 
            // txtIngreseNumSol
            // 
            this.txtIngreseNumSol.AcceptsReturn = true;
            this.txtIngreseNumSol.Location = new System.Drawing.Point(282, 32);
            this.txtIngreseNumSol.Name = "txtIngreseNumSol";
            this.txtIngreseNumSol.Size = new System.Drawing.Size(209, 27);
            this.txtIngreseNumSol.TabIndex = 1;
            // 
            // btnConsultarEstado
            // 
            this.btnConsultarEstado.Location = new System.Drawing.Point(291, 65);
            this.btnConsultarEstado.Name = "btnConsultarEstado";
            this.btnConsultarEstado.Size = new System.Drawing.Size(183, 68);
            this.btnConsultarEstado.TabIndex = 2;
            this.btnConsultarEstado.Text = "Consultar Estado del Servicio";
            this.btnConsultarEstado.UseVisualStyleBackColor = true;
            this.btnConsultarEstado.Click += new System.EventHandler(this.btnConsultarEstado_Click);
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(47, 238);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(699, 20);
            this.lblComentario.TabIndex = 3;
            this.lblComentario.Text = "Para el prototipo, solo existe solicitud con numero: 1, 2 y 3. Cada una con un es" +
    "tado diferente de prueba.";
            // 
            // frmEstadoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.btnConsultarEstado);
            this.Controls.Add(this.txtIngreseNumSol);
            this.Controls.Add(this.lblIngreseNumeroSol);
            this.Name = "frmEstadoServicio";
            this.Text = "Estado del Servicio";
            this.Load += new System.EventHandler(this.frmEstadoServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIngreseNumeroSol;
        private TextBox txtIngreseNumSol;
        private Button btnConsultarEstado;
        private Label lblComentario;
    }
}