namespace WIN_JosePorozo
{
    partial class FrmOT
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
            this.BtnAreaTriangulo = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblBase = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.LblRadio = new System.Windows.Forms.Label();
            this.TxtBase = new System.Windows.Forms.TextBox();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.TxtRadio = new System.Windows.Forms.TextBox();
            this.BtnAreaRectangulo = new System.Windows.Forms.Button();
            this.BtnAreaCirculo = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAreaTriangulo
            // 
            this.BtnAreaTriangulo.Location = new System.Drawing.Point(308, 33);
            this.BtnAreaTriangulo.Name = "BtnAreaTriangulo";
            this.BtnAreaTriangulo.Size = new System.Drawing.Size(129, 23);
            this.BtnAreaTriangulo.TabIndex = 0;
            this.BtnAreaTriangulo.Text = "Area del Triangulo";
            this.BtnAreaTriangulo.UseVisualStyleBackColor = true;
            this.BtnAreaTriangulo.Click += new System.EventHandler(this.BtnAreaTriangulo_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(160, 223);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(308, 223);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblBase
            // 
            this.LblBase.AutoSize = true;
            this.LblBase.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBase.Location = new System.Drawing.Point(44, 38);
            this.LblBase.Name = "LblBase";
            this.LblBase.Size = new System.Drawing.Size(85, 16);
            this.LblBase.TabIndex = 3;
            this.LblBase.Text = "Ingresar la Base";
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltura.Location = new System.Drawing.Point(44, 84);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(88, 16);
            this.LblAltura.TabIndex = 4;
            this.LblAltura.Text = "Ingresar la Altura";
            // 
            // LblRadio
            // 
            this.LblRadio.AutoSize = true;
            this.LblRadio.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRadio.Location = new System.Drawing.Point(44, 137);
            this.LblRadio.Name = "LblRadio";
            this.LblRadio.Size = new System.Drawing.Size(89, 16);
            this.LblRadio.TabIndex = 5;
            this.LblRadio.Text = "Ingresar el Radio";
            this.LblRadio.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtBase
            // 
            this.TxtBase.Location = new System.Drawing.Point(160, 33);
            this.TxtBase.Name = "TxtBase";
            this.TxtBase.Size = new System.Drawing.Size(100, 20);
            this.TxtBase.TabIndex = 6;
            // 
            // TxtAltura
            // 
            this.TxtAltura.Location = new System.Drawing.Point(160, 83);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(100, 20);
            this.TxtAltura.TabIndex = 7;
            // 
            // TxtRadio
            // 
            this.TxtRadio.Location = new System.Drawing.Point(160, 133);
            this.TxtRadio.Name = "TxtRadio";
            this.TxtRadio.Size = new System.Drawing.Size(100, 20);
            this.TxtRadio.TabIndex = 8;
            // 
            // BtnAreaRectangulo
            // 
            this.BtnAreaRectangulo.Location = new System.Drawing.Point(308, 77);
            this.BtnAreaRectangulo.Name = "BtnAreaRectangulo";
            this.BtnAreaRectangulo.Size = new System.Drawing.Size(129, 23);
            this.BtnAreaRectangulo.TabIndex = 9;
            this.BtnAreaRectangulo.Text = "Area del Rectangulo";
            this.BtnAreaRectangulo.UseVisualStyleBackColor = true;
            // 
            // BtnAreaCirculo
            // 
            this.BtnAreaCirculo.Location = new System.Drawing.Point(308, 137);
            this.BtnAreaCirculo.Name = "BtnAreaCirculo";
            this.BtnAreaCirculo.Size = new System.Drawing.Size(129, 23);
            this.BtnAreaCirculo.TabIndex = 10;
            this.BtnAreaCirculo.Text = "Area del Circulo";
            this.BtnAreaCirculo.UseVisualStyleBackColor = true;
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(47, 222);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(75, 23);
            this.BtnAtras.TabIndex = 11;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // FrmOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 290);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnAreaCirculo);
            this.Controls.Add(this.BtnAreaRectangulo);
            this.Controls.Add(this.TxtRadio);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.TxtBase);
            this.Controls.Add(this.LblRadio);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.LblBase);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAreaTriangulo);
            this.Name = "FrmOT";
            this.Text = "Operaciones Trigonometricas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAreaTriangulo;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblBase;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.Label LblRadio;
        private System.Windows.Forms.TextBox TxtBase;
        private System.Windows.Forms.TextBox TxtAltura;
        private System.Windows.Forms.TextBox TxtRadio;
        private System.Windows.Forms.Button BtnAreaRectangulo;
        private System.Windows.Forms.Button BtnAreaCirculo;
        private System.Windows.Forms.Button BtnAtras;
    }
}