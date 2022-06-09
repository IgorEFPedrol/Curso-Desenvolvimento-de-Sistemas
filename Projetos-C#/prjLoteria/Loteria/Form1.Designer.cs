namespace Loteria
{
    partial class Form1
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
            this.pnCartela = new System.Windows.Forms.Panel();
            this.rbMegasena = new System.Windows.Forms.RadioButton();
            this.rbLotoMania = new System.Windows.Forms.RadioButton();
            this.rbQuina = new System.Windows.Forms.RadioButton();
            this.rbLotoFacil = new System.Windows.Forms.RadioButton();
            this.btnCartela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnCartela
            // 
            this.pnCartela.BackColor = System.Drawing.Color.Aqua;
            this.pnCartela.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCartela.Location = new System.Drawing.Point(0, 0);
            this.pnCartela.Name = "pnCartela";
            this.pnCartela.Size = new System.Drawing.Size(480, 337);
            this.pnCartela.TabIndex = 0;
            // 
            // rbMegasena
            // 
            this.rbMegasena.AutoSize = true;
            this.rbMegasena.Checked = true;
            this.rbMegasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbMegasena.Location = new System.Drawing.Point(27, 355);
            this.rbMegasena.Name = "rbMegasena";
            this.rbMegasena.Size = new System.Drawing.Size(119, 24);
            this.rbMegasena.TabIndex = 0;
            this.rbMegasena.TabStop = true;
            this.rbMegasena.Text = "MEGASENA";
            this.rbMegasena.UseVisualStyleBackColor = true;
            // 
            // rbLotoMania
            // 
            this.rbLotoMania.AutoSize = true;
            this.rbLotoMania.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbLotoMania.Location = new System.Drawing.Point(27, 378);
            this.rbLotoMania.Name = "rbLotoMania";
            this.rbLotoMania.Size = new System.Drawing.Size(120, 24);
            this.rbLotoMania.TabIndex = 1;
            this.rbLotoMania.Text = "LOTOMANIA";
            this.rbLotoMania.UseVisualStyleBackColor = true;
            // 
            // rbQuina
            // 
            this.rbQuina.AutoSize = true;
            this.rbQuina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbQuina.Location = new System.Drawing.Point(152, 355);
            this.rbQuina.Name = "rbQuina";
            this.rbQuina.Size = new System.Drawing.Size(78, 24);
            this.rbQuina.TabIndex = 2;
            this.rbQuina.Text = "QUINA";
            this.rbQuina.UseVisualStyleBackColor = true;
            // 
            // rbLotoFacil
            // 
            this.rbLotoFacil.AutoSize = true;
            this.rbLotoFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbLotoFacil.Location = new System.Drawing.Point(152, 378);
            this.rbLotoFacil.Name = "rbLotoFacil";
            this.rbLotoFacil.Size = new System.Drawing.Size(115, 24);
            this.rbLotoFacil.TabIndex = 1;
            this.rbLotoFacil.Text = "LOTOFACIL";
            this.rbLotoFacil.UseVisualStyleBackColor = true;
            // 
            // btnCartela
            // 
            this.btnCartela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCartela.Location = new System.Drawing.Point(274, 343);
            this.btnCartela.Name = "btnCartela";
            this.btnCartela.Size = new System.Drawing.Size(194, 63);
            this.btnCartela.TabIndex = 3;
            this.btnCartela.Text = "GERAR CARTELA";
            this.btnCartela.UseVisualStyleBackColor = true;
            this.btnCartela.Click += new System.EventHandler(this.btnCartela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(480, 418);
            this.Controls.Add(this.btnCartela);
            this.Controls.Add(this.rbLotoFacil);
            this.Controls.Add(this.pnCartela);
            this.Controls.Add(this.rbQuina);
            this.Controls.Add(this.rbMegasena);
            this.Controls.Add(this.rbLotoMania);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERADOR DE CARTELAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnCartela;
        private System.Windows.Forms.Button btnCartela;
        private System.Windows.Forms.RadioButton rbLotoFacil;
        private System.Windows.Forms.RadioButton rbQuina;
        private System.Windows.Forms.RadioButton rbLotoMania;
        private System.Windows.Forms.RadioButton rbMegasena;
    }
}

