﻿namespace prjCalculadoraGrafica
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
            this.gbCalculo = new System.Windows.Forms.GroupBox();
            this.rbVolume = new System.Windows.Forms.RadioButton();
            this.rbPerimetro = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.lbRaio = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.gbCalculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCalculo
            // 
            this.gbCalculo.Controls.Add(this.rbVolume);
            this.gbCalculo.Controls.Add(this.rbPerimetro);
            this.gbCalculo.Controls.Add(this.rbArea);
            this.gbCalculo.Location = new System.Drawing.Point(8, 9);
            this.gbCalculo.Name = "gbCalculo";
            this.gbCalculo.Size = new System.Drawing.Size(180, 100);
            this.gbCalculo.TabIndex = 0;
            this.gbCalculo.TabStop = false;
            this.gbCalculo.Text = "Selecione:";
            // 
            // rbVolume
            // 
            this.rbVolume.AutoSize = true;
            this.rbVolume.Location = new System.Drawing.Point(6, 65);
            this.rbVolume.Name = "rbVolume";
            this.rbVolume.Size = new System.Drawing.Size(60, 17);
            this.rbVolume.TabIndex = 2;
            this.rbVolume.TabStop = true;
            this.rbVolume.Text = "Volume";
            this.rbVolume.UseVisualStyleBackColor = true;
            // 
            // rbPerimetro
            // 
            this.rbPerimetro.AutoSize = true;
            this.rbPerimetro.Location = new System.Drawing.Point(6, 42);
            this.rbPerimetro.Name = "rbPerimetro";
            this.rbPerimetro.Size = new System.Drawing.Size(71, 17);
            this.rbPerimetro.TabIndex = 1;
            this.rbPerimetro.TabStop = true;
            this.rbPerimetro.Text = "Perímetro";
            this.rbPerimetro.UseVisualStyleBackColor = true;
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Location = new System.Drawing.Point(6, 19);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(47, 17);
            this.rbArea.TabIndex = 0;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Área";
            this.rbArea.UseVisualStyleBackColor = true;
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(209, 37);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(140, 20);
            this.txtRaio.TabIndex = 1;
            // 
            // lbRaio
            // 
            this.lbRaio.AutoSize = true;
            this.lbRaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRaio.Location = new System.Drawing.Point(226, 14);
            this.lbRaio.Name = "lbRaio";
            this.lbRaio.Size = new System.Drawing.Size(104, 20);
            this.lbRaio.TabIndex = 2;
            this.lbRaio.Text = "Digite o Raio:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(209, 63);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(140, 46);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lbResultado
            // 
            this.lbResultado.BackColor = System.Drawing.Color.Gainsboro;
            this.lbResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbResultado.Location = new System.Drawing.Point(0, 114);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(354, 78);
            this.lbResultado.TabIndex = 4;
            this.lbResultado.Text = "Resultado:";
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbResultado.Click += new System.EventHandler(this.lbResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 192);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbRaio);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.gbCalculo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA GRÁFICA";
            this.gbCalculo.ResumeLayout(false);
            this.gbCalculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCalculo;
        private System.Windows.Forms.RadioButton rbVolume;
        private System.Windows.Forms.RadioButton rbPerimetro;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Label lbRaio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbResultado;
    }
}
