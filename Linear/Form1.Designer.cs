namespace Linear
{
    partial class Form1
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
            this.lbl_inicialX = new System.Windows.Forms.Label();
            this.lbl_InicialY = new System.Windows.Forms.Label();
            this.lbl_FinalX = new System.Windows.Forms.Label();
            this.lbl_FinalY = new System.Windows.Forms.Label();
            this.txt_X1 = new System.Windows.Forms.TextBox();
            this.txt_Y1 = new System.Windows.Forms.TextBox();
            this.txt_X2 = new System.Windows.Forms.TextBox();
            this.txt_Y2 = new System.Windows.Forms.TextBox();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.lbl_IndicacionX = new System.Windows.Forms.Label();
            this.lbl_IndicacionY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_inicialX
            // 
            this.lbl_inicialX.AutoSize = true;
            this.lbl_inicialX.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicialX.Location = new System.Drawing.Point(12, 47);
            this.lbl_inicialX.Name = "lbl_inicialX";
            this.lbl_inicialX.Size = new System.Drawing.Size(126, 19);
            this.lbl_inicialX.TabIndex = 0;
            this.lbl_inicialX.Text = "En coordenada X:";
            // 
            // lbl_InicialY
            // 
            this.lbl_InicialY.AutoSize = true;
            this.lbl_InicialY.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InicialY.Location = new System.Drawing.Point(228, 47);
            this.lbl_InicialY.Name = "lbl_InicialY";
            this.lbl_InicialY.Size = new System.Drawing.Size(126, 19);
            this.lbl_InicialY.TabIndex = 1;
            this.lbl_InicialY.Text = "En coordenada X:";
            // 
            // lbl_FinalX
            // 
            this.lbl_FinalX.AutoSize = true;
            this.lbl_FinalX.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FinalX.Location = new System.Drawing.Point(12, 90);
            this.lbl_FinalX.Name = "lbl_FinalX";
            this.lbl_FinalX.Size = new System.Drawing.Size(125, 19);
            this.lbl_FinalX.TabIndex = 2;
            this.lbl_FinalX.Text = "En coordenada Y:";
            // 
            // lbl_FinalY
            // 
            this.lbl_FinalY.AutoSize = true;
            this.lbl_FinalY.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FinalY.Location = new System.Drawing.Point(229, 91);
            this.lbl_FinalY.Name = "lbl_FinalY";
            this.lbl_FinalY.Size = new System.Drawing.Size(125, 19);
            this.lbl_FinalY.TabIndex = 3;
            this.lbl_FinalY.Text = "En coordenada Y:";
            // 
            // txt_X1
            // 
            this.txt_X1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_X1.Location = new System.Drawing.Point(147, 39);
            this.txt_X1.Multiline = true;
            this.txt_X1.Name = "txt_X1";
            this.txt_X1.Size = new System.Drawing.Size(36, 30);
            this.txt_X1.TabIndex = 4;
            this.txt_X1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Y1
            // 
            this.txt_Y1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Y1.Location = new System.Drawing.Point(147, 91);
            this.txt_Y1.Multiline = true;
            this.txt_Y1.Name = "txt_Y1";
            this.txt_Y1.Size = new System.Drawing.Size(36, 30);
            this.txt_Y1.TabIndex = 5;
            this.txt_Y1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_X2
            // 
            this.txt_X2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_X2.Location = new System.Drawing.Point(356, 39);
            this.txt_X2.Multiline = true;
            this.txt_X2.Name = "txt_X2";
            this.txt_X2.Size = new System.Drawing.Size(36, 30);
            this.txt_X2.TabIndex = 6;
            this.txt_X2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Y2
            // 
            this.txt_Y2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Y2.Location = new System.Drawing.Point(356, 90);
            this.txt_Y2.Multiline = true;
            this.txt_Y2.Name = "txt_Y2";
            this.txt_Y2.Size = new System.Drawing.Size(36, 30);
            this.txt_Y2.TabIndex = 7;
            this.txt_Y2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDibujar
            // 
            this.btnDibujar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDibujar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDibujar.Location = new System.Drawing.Point(16, 140);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(100, 26);
            this.btnDibujar.TabIndex = 8;
            this.btnDibujar.Text = "Dibujar Línea";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(18, 178);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(124, 17);
            this.lblContador.TabIndex = 9;
            this.lblContador.Text = "Contador de líneas";
            // 
            // txtContador
            // 
            this.txtContador.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContador.Location = new System.Drawing.Point(152, 173);
            this.txtContador.Multiline = true;
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(31, 22);
            this.txtContador.TabIndex = 10;
            this.txtContador.Text = "0";
            this.txtContador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_IndicacionX
            // 
            this.lbl_IndicacionX.AutoSize = true;
            this.lbl_IndicacionX.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IndicacionX.Location = new System.Drawing.Point(12, 9);
            this.lbl_IndicacionX.Name = "lbl_IndicacionX";
            this.lbl_IndicacionX.Size = new System.Drawing.Size(130, 19);
            this.lbl_IndicacionX.TabIndex = 11;
            this.lbl_IndicacionX.Text = "Punto de partida: ";
            this.lbl_IndicacionX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_IndicacionY
            // 
            this.lbl_IndicacionY.AutoSize = true;
            this.lbl_IndicacionY.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IndicacionY.Location = new System.Drawing.Point(229, 9);
            this.lbl_IndicacionY.Name = "lbl_IndicacionY";
            this.lbl_IndicacionY.Size = new System.Drawing.Size(127, 19);
            this.lbl_IndicacionY.TabIndex = 12;
            this.lbl_IndicacionY.Text = "Punto de llegada:";
            this.lbl_IndicacionY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 317);
            this.Controls.Add(this.lbl_IndicacionY);
            this.Controls.Add(this.lbl_IndicacionX);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.txt_Y2);
            this.Controls.Add(this.txt_X2);
            this.Controls.Add(this.txt_Y1);
            this.Controls.Add(this.txt_X1);
            this.Controls.Add(this.lbl_FinalY);
            this.Controls.Add(this.lbl_FinalX);
            this.Controls.Add(this.lbl_InicialY);
            this.Controls.Add(this.lbl_inicialX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_inicialX;
        private System.Windows.Forms.Label lbl_InicialY;
        private System.Windows.Forms.Label lbl_FinalX;
        private System.Windows.Forms.Label lbl_FinalY;
        private System.Windows.Forms.TextBox txt_X1;
        private System.Windows.Forms.TextBox txt_Y1;
        private System.Windows.Forms.TextBox txt_X2;
        private System.Windows.Forms.TextBox txt_Y2;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Label lbl_IndicacionX;
        private System.Windows.Forms.Label lbl_IndicacionY;
    }
}

