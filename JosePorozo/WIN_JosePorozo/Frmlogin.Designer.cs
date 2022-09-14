namespace WIN_JosePorozo
{
    partial class Frmlogin
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.Btbprocesar = new System.Windows.Forms.Button();
            this.Lblusuario = new System.Windows.Forms.Label();
            this.Lblclave = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(154, 124);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Btbprocesar
            // 
            this.Btbprocesar.Location = new System.Drawing.Point(33, 124);
            this.Btbprocesar.Name = "Btbprocesar";
            this.Btbprocesar.Size = new System.Drawing.Size(75, 23);
            this.Btbprocesar.TabIndex = 1;
            this.Btbprocesar.Text = "Procesar";
            this.Btbprocesar.UseVisualStyleBackColor = true;
            this.Btbprocesar.Click += new System.EventHandler(this.Btbprocesar_Click);
            // 
            // Lblusuario
            // 
            this.Lblusuario.AutoSize = true;
            this.Lblusuario.Location = new System.Drawing.Point(30, 27);
            this.Lblusuario.Name = "Lblusuario";
            this.Lblusuario.Size = new System.Drawing.Size(84, 13);
            this.Lblusuario.TabIndex = 2;
            this.Lblusuario.Text = "Ingresar Usuario";
            // 
            // Lblclave
            // 
            this.Lblclave.AutoSize = true;
            this.Lblclave.Location = new System.Drawing.Point(30, 68);
            this.Lblclave.Name = "Lblclave";
            this.Lblclave.Size = new System.Drawing.Size(75, 13);
            this.Lblclave.TabIndex = 3;
            this.Lblclave.Text = "Ingresar Clave";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(142, 27);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(142, 68);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 5;
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 174);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Lblclave);
            this.Controls.Add(this.Lblusuario);
            this.Controls.Add(this.Btbprocesar);
            this.Controls.Add(this.BtnSalir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button Btbprocesar;
        private System.Windows.Forms.Label Lblusuario;
        private System.Windows.Forms.Label Lblclave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
    }
}

