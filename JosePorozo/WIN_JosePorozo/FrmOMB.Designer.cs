namespace WIN_JosePorozo
{
    partial class FrmOMB
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
            this.LblNumUno = new System.Windows.Forms.Label();
            this.LblNumDos = new System.Windows.Forms.Label();
            this.TxtNumeroUno = new System.Windows.Forms.TextBox();
            this.TxtNumeroDos = new System.Windows.Forms.TextBox();
            this.BtnSumar = new System.Windows.Forms.Button();
            this.BtnRestar = new System.Windows.Forms.Button();
            this.BtnMultiplicar = new System.Windows.Forms.Button();
            this.BtnDividir = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNumUno
            // 
            this.LblNumUno.AutoSize = true;
            this.LblNumUno.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumUno.Location = new System.Drawing.Point(38, 43);
            this.LblNumUno.Name = "LblNumUno";
            this.LblNumUno.Size = new System.Drawing.Size(68, 16);
            this.LblNumUno.TabIndex = 0;
            this.LblNumUno.Text = "Número Uno";
            // 
            // LblNumDos
            // 
            this.LblNumDos.AutoSize = true;
            this.LblNumDos.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumDos.Location = new System.Drawing.Point(38, 97);
            this.LblNumDos.Name = "LblNumDos";
            this.LblNumDos.Size = new System.Drawing.Size(67, 16);
            this.LblNumDos.TabIndex = 1;
            this.LblNumDos.Text = "Número Dos";
            // 
            // TxtNumeroUno
            // 
            this.TxtNumeroUno.Location = new System.Drawing.Point(165, 43);
            this.TxtNumeroUno.Name = "TxtNumeroUno";
            this.TxtNumeroUno.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroUno.TabIndex = 2;
            this.TxtNumeroUno.TextChanged += new System.EventHandler(this.TxtNumeroUno_TextChanged);
            // 
            // TxtNumeroDos
            // 
            this.TxtNumeroDos.Location = new System.Drawing.Point(165, 97);
            this.TxtNumeroDos.Name = "TxtNumeroDos";
            this.TxtNumeroDos.Size = new System.Drawing.Size(100, 20);
            this.TxtNumeroDos.TabIndex = 3;
            // 
            // BtnSumar
            // 
            this.BtnSumar.Location = new System.Drawing.Point(321, 19);
            this.BtnSumar.Name = "BtnSumar";
            this.BtnSumar.Size = new System.Drawing.Size(75, 23);
            this.BtnSumar.TabIndex = 4;
            this.BtnSumar.Text = "Sumar";
            this.BtnSumar.UseVisualStyleBackColor = true;
            this.BtnSumar.Click += new System.EventHandler(this.BtnSumar_Click);
            // 
            // BtnRestar
            // 
            this.BtnRestar.Location = new System.Drawing.Point(321, 68);
            this.BtnRestar.Name = "BtnRestar";
            this.BtnRestar.Size = new System.Drawing.Size(75, 23);
            this.BtnRestar.TabIndex = 5;
            this.BtnRestar.Text = "Restar";
            this.BtnRestar.UseVisualStyleBackColor = true;
            this.BtnRestar.Click += new System.EventHandler(this.BtnRestar_Click);
            // 
            // BtnMultiplicar
            // 
            this.BtnMultiplicar.Location = new System.Drawing.Point(321, 119);
            this.BtnMultiplicar.Name = "BtnMultiplicar";
            this.BtnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.BtnMultiplicar.TabIndex = 6;
            this.BtnMultiplicar.Text = "Multiplicar";
            this.BtnMultiplicar.UseVisualStyleBackColor = true;
            this.BtnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicar_Click);
            // 
            // BtnDividir
            // 
            this.BtnDividir.Location = new System.Drawing.Point(321, 167);
            this.BtnDividir.Name = "BtnDividir";
            this.BtnDividir.Size = new System.Drawing.Size(75, 23);
            this.BtnDividir.TabIndex = 7;
            this.BtnDividir.Text = "Dividir ";
            this.BtnDividir.UseVisualStyleBackColor = true;
            this.BtnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnLimpiar.Location = new System.Drawing.Point(41, 150);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 40);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.Location = new System.Drawing.Point(165, 150);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 40);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmOMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 209);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnDividir);
            this.Controls.Add(this.BtnMultiplicar);
            this.Controls.Add(this.BtnRestar);
            this.Controls.Add(this.BtnSumar);
            this.Controls.Add(this.TxtNumeroDos);
            this.Controls.Add(this.TxtNumeroUno);
            this.Controls.Add(this.LblNumDos);
            this.Controls.Add(this.LblNumUno);
            this.Name = "FrmOMB";
            this.Text = " OPERACIONES MATEMÁTICAS BÁSICAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumUno;
        private System.Windows.Forms.Label LblNumDos;
        private System.Windows.Forms.TextBox TxtNumeroUno;
        private System.Windows.Forms.TextBox TxtNumeroDos;
        private System.Windows.Forms.Button BtnSumar;
        private System.Windows.Forms.Button BtnRestar;
        private System.Windows.Forms.Button BtnMultiplicar;
        private System.Windows.Forms.Button BtnDividir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
    }
}