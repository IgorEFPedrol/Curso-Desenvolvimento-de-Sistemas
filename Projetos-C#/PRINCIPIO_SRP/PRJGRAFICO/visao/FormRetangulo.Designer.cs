namespace PRJGRAFICO.visao
{
    partial class FormRetangulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnPlotar = new System.Windows.Forms.Button();
            this.pnDesenho = new System.Windows.Forms.Panel();
            this.lbEscala = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.escala = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE O COMPRIMENTO EM CM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "DIGITE A ALTURA EM CM";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(511, 74);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(248, 26);
            this.txtA.TabIndex = 1;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(107, 74);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(275, 26);
            this.txtC.TabIndex = 1;
            // 
            // btnPlotar
            // 
            this.btnPlotar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnPlotar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlotar.ForeColor = System.Drawing.Color.White;
            this.btnPlotar.Location = new System.Drawing.Point(52, 119);
            this.btnPlotar.Name = "btnPlotar";
            this.btnPlotar.Size = new System.Drawing.Size(753, 80);
            this.btnPlotar.TabIndex = 2;
            this.btnPlotar.Text = "PLOTAR RETÂNGULO";
            this.btnPlotar.UseVisualStyleBackColor = false;
            this.btnPlotar.Click += new System.EventHandler(this.btnPlotar_Click);
            // 
            // pnDesenho
            // 
            this.pnDesenho.Location = new System.Drawing.Point(12, 223);
            this.pnDesenho.Name = "pnDesenho";
            this.pnDesenho.Size = new System.Drawing.Size(832, 416);
            this.pnDesenho.TabIndex = 3;
            // 
            // lbEscala
            // 
            this.lbEscala.AutoSize = true;
            this.lbEscala.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEscala.Location = new System.Drawing.Point(344, 685);
            this.lbEscala.Name = "lbEscala";
            this.lbEscala.Size = new System.Drawing.Size(189, 18);
            this.lbEscala.TabIndex = 4;
            this.lbEscala.Text = "ESCALA DO DESENHO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 685);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "0%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(784, 685);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "100%";
            // 
            // escala
            // 
            this.escala.Location = new System.Drawing.Point(12, 642);
            this.escala.Minimum = 1;
            this.escala.Name = "escala";
            this.escala.Size = new System.Drawing.Size(832, 17);
            this.escala.TabIndex = 7;
            this.escala.Value = 1;
            this.escala.Scroll += new System.Windows.Forms.ScrollEventHandler(this.escala_Scroll);
            // 
            // FormRetangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 712);
            this.Controls.Add(this.escala);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbEscala);
            this.Controls.Add(this.pnDesenho);
            this.Controls.Add(this.btnPlotar);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRetangulo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLOTADOR GRÁFICO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnPlotar;
        private System.Windows.Forms.Panel pnDesenho;
        private System.Windows.Forms.Label lbEscala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar escala;
    }
}