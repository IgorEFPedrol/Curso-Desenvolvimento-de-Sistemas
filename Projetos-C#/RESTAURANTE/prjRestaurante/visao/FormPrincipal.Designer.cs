namespace prjRestaurante.visao
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnComandas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProdutos,
            this.mnMesas,
            this.mnComandas,
            this.mnSair});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.menu.Size = new System.Drawing.Size(118, 639);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // mnProdutos
            // 
            this.mnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("mnProdutos.Image")));
            this.mnProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnProdutos.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnProdutos.Name = "mnProdutos";
            this.mnProdutos.Padding = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.mnProdutos.Size = new System.Drawing.Size(77, 87);
            this.mnProdutos.Text = "PRODUTOS";
            this.mnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnMesas
            // 
            this.mnMesas.Image = ((System.Drawing.Image)(resources.GetObject("mnMesas.Image")));
            this.mnMesas.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnMesas.Name = "mnMesas";
            this.mnMesas.Padding = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.mnMesas.Size = new System.Drawing.Size(77, 40);
            this.mnMesas.Text = "MESAS";
            // 
            // mnComandas
            // 
            this.mnComandas.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnComandas.Name = "mnComandas";
            this.mnComandas.Padding = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.mnComandas.Size = new System.Drawing.Size(77, 39);
            this.mnComandas.Text = "COMANDAS";
            // 
            // mnSair
            // 
            this.mnSair.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnSair.Name = "mnSair";
            this.mnSair.Padding = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.mnSair.Size = new System.Drawing.Size(77, 39);
            this.mnSair.Text = "SAIR";
            this.mnSair.Click += new System.EventHandler(this.mnSair_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 639);
            this.Controls.Add(this.menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROLE DE RESTAURANTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnMesas;
        private System.Windows.Forms.ToolStripMenuItem mnComandas;
        private System.Windows.Forms.ToolStripMenuItem mnSair;
    }
}