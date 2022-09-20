namespace WIN_JosePorozo
{
    partial class FrmSerieFibonacci
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
            this.LblIngresarValor = new System.Windows.Forms.Label();
            this.LblListaFibonacci = new System.Windows.Forms.Label();
            this.BtnProcesar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.TxtListaFibnacci = new System.Windows.Forms.TextBox();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblIngresarValor
            // 
            this.LblIngresarValor.AutoSize = true;
            this.LblIngresarValor.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIngresarValor.Location = new System.Drawing.Point(55, 38);
            this.LblIngresarValor.Name = "LblIngresarValor";
            this.LblIngresarValor.Size = new System.Drawing.Size(32, 16);
            this.LblIngresarValor.TabIndex = 0;
            this.LblIngresarValor.Text = "Valor";
            // 
            // LblListaFibonacci
            // 
            this.LblListaFibonacci.AutoSize = true;
            this.LblListaFibonacci.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListaFibonacci.Location = new System.Drawing.Point(55, 82);
            this.LblListaFibonacci.Name = "LblListaFibonacci";
            this.LblListaFibonacci.Size = new System.Drawing.Size(119, 16);
            this.LblListaFibonacci.TabIndex = 1;
            this.LblListaFibonacci.Text = "Lista de Serie Fibonacci";
            // 
            // BtnProcesar
            // 
            this.BtnProcesar.Location = new System.Drawing.Point(371, 35);
            this.BtnProcesar.Name = "BtnProcesar";
            this.BtnProcesar.Size = new System.Drawing.Size(75, 23);
            this.BtnProcesar.TabIndex = 2;
            this.BtnProcesar.Text = "Procesar";
            this.BtnProcesar.UseVisualStyleBackColor = true;
            this.BtnProcesar.Click += new System.EventHandler(this.BtnProcesar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(206, 229);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 34);
            this.BtnLimpiar.TabIndex = 3;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(358, 229);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 34);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(188, 34);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(133, 20);
            this.TxtValor.TabIndex = 5;
            // 
            // TxtListaFibnacci
            // 
            this.TxtListaFibnacci.Location = new System.Drawing.Point(58, 118);
            this.TxtListaFibnacci.Multiline = true;
            this.TxtListaFibnacci.Name = "TxtListaFibnacci";
            this.TxtListaFibnacci.Size = new System.Drawing.Size(474, 86);
            this.TxtListaFibnacci.TabIndex = 6;
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(58, 229);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(75, 34);
            this.BtnAtras.TabIndex = 7;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // FrmSerieFibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 291);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.TxtListaFibnacci);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnProcesar);
            this.Controls.Add(this.LblListaFibonacci);
            this.Controls.Add(this.LblIngresarValor);
            this.Name = "FrmSerieFibonacci";
            this.Text = "Serie Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIngresarValor;
        private System.Windows.Forms.Label LblListaFibonacci;
        private System.Windows.Forms.Button BtnProcesar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox TxtListaFibnacci;
        private System.Windows.Forms.Button BtnAtras;
    }
}