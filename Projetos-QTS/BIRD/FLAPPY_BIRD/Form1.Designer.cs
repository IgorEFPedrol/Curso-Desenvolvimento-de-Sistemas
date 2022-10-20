namespace FLAPPY_BIRD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bird = new System.Windows.Forms.PictureBox();
            this.jogo = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.tuboInferior = new System.Windows.Forms.PictureBox();
            this.tuboSuperior = new System.Windows.Forms.PictureBox();
            this.lbPlacar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboSuperior)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(109, 209);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(50, 50);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // jogo
            // 
            this.jogo.Enabled = true;
            this.jogo.Tick += new System.EventHandler(this.jogo_Tick);
            // 
            // ground
            // 
            this.ground.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground.BackgroundImage")));
            this.ground.Location = new System.Drawing.Point(-1, 399);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(888, 96);
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // tuboInferior
            // 
            this.tuboInferior.Image = ((System.Drawing.Image)(resources.GetObject("tuboInferior.Image")));
            this.tuboInferior.Location = new System.Drawing.Point(616, 218);
            this.tuboInferior.Name = "tuboInferior";
            this.tuboInferior.Size = new System.Drawing.Size(75, 183);
            this.tuboInferior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tuboInferior.TabIndex = 2;
            this.tuboInferior.TabStop = false;
            // 
            // tuboSuperior
            // 
            this.tuboSuperior.Image = ((System.Drawing.Image)(resources.GetObject("tuboSuperior.Image")));
            this.tuboSuperior.Location = new System.Drawing.Point(420, -2);
            this.tuboSuperior.Name = "tuboSuperior";
            this.tuboSuperior.Size = new System.Drawing.Size(75, 156);
            this.tuboSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tuboSuperior.TabIndex = 3;
            this.tuboSuperior.TabStop = false;
            // 
            // lbPlacar
            // 
            this.lbPlacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.lbPlacar.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlacar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPlacar.Location = new System.Drawing.Point(665, 441);
            this.lbPlacar.Name = "lbPlacar";
            this.lbPlacar.Size = new System.Drawing.Size(206, 40);
            this.lbPlacar.TabIndex = 4;
            this.lbPlacar.Text = "placar = 0";
            this.lbPlacar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(883, 490);
            this.Controls.Add(this.lbPlacar);
            this.Controls.Add(this.tuboSuperior);
            this.Controls.Add(this.tuboInferior);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboSuperior)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Timer jogo;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox tuboInferior;
        private System.Windows.Forms.PictureBox tuboSuperior;
        private System.Windows.Forms.Label lbPlacar;
    }
}

