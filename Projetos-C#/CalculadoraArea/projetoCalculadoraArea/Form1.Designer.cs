namespace projetoCalculadoraArea
{
    partial class btnCalc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbRaio = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.btnCalcularArea = new System.Windows.Forms.Button();
            this.lbResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbRaio
            // 
            this.lbRaio.AutoSize = true;
            this.lbRaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbRaio.Location = new System.Drawing.Point(136, 30);
            this.lbRaio.Name = "lbRaio";
            this.lbRaio.Size = new System.Drawing.Size(205, 24);
            this.lbRaio.TabIndex = 0;
            this.lbRaio.Text = "Digite o raio do Círculo:";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(140, 67);
            this.txtRaio.MaxLength = 10;
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(201, 20);
            this.txtRaio.TabIndex = 1;
            this.txtRaio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcularArea
            // 
            this.btnCalcularArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularArea.Location = new System.Drawing.Point(140, 114);
            this.btnCalcularArea.Name = "btnCalcularArea";
            this.btnCalcularArea.Size = new System.Drawing.Size(201, 38);
            this.btnCalcularArea.TabIndex = 2;
            this.btnCalcularArea.Text = "CALCULAR ÁREA";
            this.btnCalcularArea.UseVisualStyleBackColor = true;
            this.btnCalcularArea.Click += new System.EventHandler(this.btnCalcularArea_Click);
            // 
            // lbResposta
            // 
            this.lbResposta.BackColor = System.Drawing.Color.White;
            this.lbResposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbResposta.Location = new System.Drawing.Point(136, 179);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(205, 67);
            this.lbResposta.TabIndex = 3;
            this.lbResposta.Text = "Resposta: ";
            this.lbResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(471, 378);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.btnCalcularArea);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.lbRaio);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "btnCalc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA DE ÁREA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRaio;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Button btnCalcularArea;
        private System.Windows.Forms.Label lbResposta;

    }
}

