namespace GRUPO_C.formularios
{
    partial class frmEstadoCuenta
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
            this.lblFacturasPagadas = new System.Windows.Forms.Label();
            this.lblFacturasAPagar = new System.Windows.Forms.Label();
            this.lblPendienteFacturar = new System.Windows.Forms.Label();
            this.lblSaldoEstadodeCuenta = new System.Windows.Forms.Label();
            this.lstFacturasAPagar = new System.Windows.Forms.ListBox();
            this.btnFacturasAPagar = new System.Windows.Forms.Button();
            this.lvwPendienteFacturar = new System.Windows.Forms.ListView();
            this.lvwFacturasPagadas = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblFacturasPagadas
            // 
            this.lblFacturasPagadas.AutoSize = true;
            this.lblFacturasPagadas.Location = new System.Drawing.Point(62, 80);
            this.lblFacturasPagadas.Name = "lblFacturasPagadas";
            this.lblFacturasPagadas.Size = new System.Drawing.Size(121, 20);
            this.lblFacturasPagadas.TabIndex = 0;
            this.lblFacturasPagadas.Text = "Facturas Pagadas";
            // 
            // lblFacturasAPagar
            // 
            this.lblFacturasAPagar.AutoSize = true;
            this.lblFacturasAPagar.Location = new System.Drawing.Point(346, 80);
            this.lblFacturasAPagar.Name = "lblFacturasAPagar";
            this.lblFacturasAPagar.Size = new System.Drawing.Size(115, 20);
            this.lblFacturasAPagar.TabIndex = 1;
            this.lblFacturasAPagar.Text = "Facturas a Pagar";
            // 
            // lblPendienteFacturar
            // 
            this.lblPendienteFacturar.AutoSize = true;
            this.lblPendienteFacturar.Location = new System.Drawing.Point(562, 80);
            this.lblPendienteFacturar.Name = "lblPendienteFacturar";
            this.lblPendienteFacturar.Size = new System.Drawing.Size(203, 20);
            this.lblPendienteFacturar.TabIndex = 2;
            this.lblPendienteFacturar.Text = "Envíos Pendientes de Facturar";
            // 
            // lblSaldoEstadodeCuenta
            // 
            this.lblSaldoEstadodeCuenta.AutoSize = true;
            this.lblSaldoEstadodeCuenta.Location = new System.Drawing.Point(216, 31);
            this.lblSaldoEstadodeCuenta.Name = "lblSaldoEstadodeCuenta";
            this.lblSaldoEstadodeCuenta.Size = new System.Drawing.Size(262, 20);
            this.lblSaldoEstadodeCuenta.TabIndex = 3;
            this.lblSaldoEstadodeCuenta.Text = "No tiene facturas pendientes de pago.";
            this.lblSaldoEstadodeCuenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstFacturasAPagar
            // 
            this.lstFacturasAPagar.FormattingEnabled = true;
            this.lstFacturasAPagar.ItemHeight = 20;
            this.lstFacturasAPagar.Location = new System.Drawing.Point(287, 112);
            this.lstFacturasAPagar.Name = "lstFacturasAPagar";
            this.lstFacturasAPagar.Size = new System.Drawing.Size(221, 204);
            this.lstFacturasAPagar.TabIndex = 6;
            // 
            // btnFacturasAPagar
            // 
            this.btnFacturasAPagar.Location = new System.Drawing.Point(315, 332);
            this.btnFacturasAPagar.Name = "btnFacturasAPagar";
            this.btnFacturasAPagar.Size = new System.Drawing.Size(131, 70);
            this.btnFacturasAPagar.TabIndex = 7;
            this.btnFacturasAPagar.Text = "Pagar Factura";
            this.btnFacturasAPagar.UseVisualStyleBackColor = true;
            this.btnFacturasAPagar.Click += new System.EventHandler(this.btnFacturasAPagar_Click);
            // 
            // lvwPendienteFacturar
            // 
            this.lvwPendienteFacturar.HideSelection = true;
            this.lvwPendienteFacturar.Location = new System.Drawing.Point(562, 112);
            this.lvwPendienteFacturar.Name = "lvwPendienteFacturar";
            this.lvwPendienteFacturar.Size = new System.Drawing.Size(214, 204);
            this.lvwPendienteFacturar.TabIndex = 8;
            this.lvwPendienteFacturar.UseCompatibleStateImageBehavior = false;
            this.lvwPendienteFacturar.View = System.Windows.Forms.View.List;
            // 
            // lvwFacturasPagadas
            // 
            this.lvwFacturasPagadas.HideSelection = true;
            this.lvwFacturasPagadas.Location = new System.Drawing.Point(21, 112);
            this.lvwFacturasPagadas.Name = "lvwFacturasPagadas";
            this.lvwFacturasPagadas.Size = new System.Drawing.Size(214, 204);
            this.lvwFacturasPagadas.TabIndex = 9;
            this.lvwFacturasPagadas.UseCompatibleStateImageBehavior = false;
            this.lvwFacturasPagadas.View = System.Windows.Forms.View.List;
            // 
            // frmEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwFacturasPagadas);
            this.Controls.Add(this.lvwPendienteFacturar);
            this.Controls.Add(this.lblFacturasAPagar);
            this.Controls.Add(this.lstFacturasAPagar);
            this.Controls.Add(this.btnFacturasAPagar);
            this.Controls.Add(this.lblSaldoEstadodeCuenta);
            this.Controls.Add(this.lblPendienteFacturar);
            this.Controls.Add(this.lblFacturasPagadas);
            this.Name = "frmEstadoCuenta";
            this.Text = "Estado de Cuenta";
            this.Load += new System.EventHandler(this.frmEstadoCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFacturasPagadas;
        private Label lblFacturasAPagar;
        private Label lblPendienteFacturar;
        private Label lblSaldoEstadodeCuenta;
        private ListBox lstFacturasAPagar;
        private Button btnFacturasAPagar;
        private ListView lvwPendienteFacturar;
        private ListView lvwFacturasPagadas;
    }
}