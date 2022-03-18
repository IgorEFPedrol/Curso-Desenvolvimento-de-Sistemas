namespace prjJogoForca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnLetra = new System.Windows.Forms.Panel();
            this.btnJogar = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.lbLetra = new System.Windows.Forms.Label();
            this.pnPalavra = new System.Windows.Forms.Panel();
            this.pbForca = new System.Windows.Forms.PictureBox();
            this.pbBoneco = new System.Windows.Forms.PictureBox();
            this.pnLetra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoneco)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLetra
            // 
            this.pnLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLetra.Controls.Add(this.btnJogar);
            this.pnLetra.Controls.Add(this.txtLetra);
            this.pnLetra.Controls.Add(this.lbLetra);
            this.pnLetra.Location = new System.Drawing.Point(12, 12);
            this.pnLetra.Name = "pnLetra";
            this.pnLetra.Size = new System.Drawing.Size(201, 157);
            this.pnLetra.TabIndex = 0;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Silver;
            this.btnJogar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnJogar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.btnJogar.ForeColor = System.Drawing.Color.Black;
            this.btnJogar.Location = new System.Drawing.Point(0, 90);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(199, 65);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.txtLetra.Location = new System.Drawing.Point(16, 48);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(169, 33);
            this.txtLetra.TabIndex = 1;
            this.txtLetra.Text = "A";
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLetra
            // 
            this.lbLetra.BackColor = System.Drawing.Color.Black;
            this.lbLetra.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLetra.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetra.ForeColor = System.Drawing.Color.White;
            this.lbLetra.Location = new System.Drawing.Point(0, 0);
            this.lbLetra.Name = "lbLetra";
            this.lbLetra.Size = new System.Drawing.Size(199, 36);
            this.lbLetra.TabIndex = 0;
            this.lbLetra.Text = "DIGITE LETRA";
            this.lbLetra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnPalavra
            // 
            this.pnPalavra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPalavra.Location = new System.Drawing.Point(245, 13);
            this.pnPalavra.Name = "pnPalavra";
            this.pnPalavra.Size = new System.Drawing.Size(394, 155);
            this.pnPalavra.TabIndex = 1;
            // 
            // pbForca
            // 
            this.pbForca.Image = ((System.Drawing.Image)(resources.GetObject("pbForca.Image")));
            this.pbForca.Location = new System.Drawing.Point(12, 175);
            this.pbForca.Name = "pbForca";
            this.pbForca.Size = new System.Drawing.Size(322, 417);
            this.pbForca.TabIndex = 2;
            this.pbForca.TabStop = false;
            // 
            // pbBoneco
            // 
            this.pbBoneco.Location = new System.Drawing.Point(125, 221);
            this.pbBoneco.Name = "pbBoneco";
            this.pbBoneco.Size = new System.Drawing.Size(196, 434);
            this.pbBoneco.TabIndex = 3;
            this.pbBoneco.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 684);
            this.Controls.Add(this.pbBoneco);
            this.Controls.Add(this.pbForca);
            this.Controls.Add(this.pnPalavra);
            this.Controls.Add(this.pnLetra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOGO DA FORCA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnLetra.ResumeLayout(false);
            this.pnLetra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoneco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLetra;
        private System.Windows.Forms.Label lbLetra;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Panel pnPalavra;
        private System.Windows.Forms.PictureBox pbForca;
        private System.Windows.Forms.PictureBox pbBoneco;
    }
}

