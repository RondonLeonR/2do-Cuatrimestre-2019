namespace frmPrincipal
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lstVisor = new System.Windows.Forms.ListBox();
            this.btnTraer = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(34, 38);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(314, 20);
            this.txtValor.TabIndex = 0;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(411, 12);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(191, 32);
            this.btnEntrar.TabIndex = 1;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lstVisor
            // 
            this.lstVisor.FormattingEnabled = true;
            this.lstVisor.Location = new System.Drawing.Point(12, 92);
            this.lstVisor.Name = "lstVisor";
            this.lstVisor.Size = new System.Drawing.Size(590, 225);
            this.lstVisor.TabIndex = 2;
            // 
            // btnTraer
            // 
            this.btnTraer.Location = new System.Drawing.Point(34, 324);
            this.btnTraer.Name = "btnTraer";
            this.btnTraer.Size = new System.Drawing.Size(106, 41);
            this.btnTraer.TabIndex = 3;
            this.btnTraer.Text = "Traer";
            this.btnTraer.UseVisualStyleBackColor = true;
            this.btnTraer.Click += new System.EventHandler(this.btnTraer_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(411, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(191, 36);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 390);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnTraer);
            this.Controls.Add(this.lstVisor);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtValor);
            this.Name = "frmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.ListBox lstVisor;
        private System.Windows.Forms.Button btnTraer;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

