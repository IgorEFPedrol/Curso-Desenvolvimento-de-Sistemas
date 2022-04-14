namespace prjRelogio
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
            this.components = new System.ComponentModel.Container();
            this.pbRelogio = new System.Windows.Forms.PictureBox();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnPonteiro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFundo = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelogio)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbRelogio
            // 
            this.pbRelogio.Location = new System.Drawing.Point(10, 52);
            this.pbRelogio.Name = "pbRelogio";
            this.pbRelogio.Size = new System.Drawing.Size(321, 315);
            this.pbRelogio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRelogio.TabIndex = 0;
            this.pbRelogio.TabStop = false;
            // 
            // relogio
            // 
            this.relogio.Enabled = true;
            this.relogio.Interval = 1000;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPonteiro,
            this.mnFundo});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(343, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // mnPonteiro
            // 
            this.mnPonteiro.Name = "mnPonteiro";
            this.mnPonteiro.Size = new System.Drawing.Size(75, 20);
            this.mnPonteiro.Text = "PONTEIRO";
            // 
            // mnFundo
            // 
            this.mnFundo.Name = "mnFundo";
            this.mnFundo.Size = new System.Drawing.Size(59, 20);
            this.mnFundo.Text = "FUNDO";
            this.mnFundo.Click += new System.EventHandler(this.mnFundo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 379);
            this.Controls.Add(this.pbRelogio);
            this.Controls.Add(this.menu);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELOGIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRelogio)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRelogio;
        private System.Windows.Forms.Timer relogio;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnPonteiro;
        private System.Windows.Forms.ToolStripMenuItem mnFundo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

