namespace prjConversorTemperatura
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
            this.gbFrom = new System.Windows.Forms.GroupBox();
            this.rbFromK = new System.Windows.Forms.RadioButton();
            this.rbFromF = new System.Windows.Forms.RadioButton();
            this.rbFromC = new System.Windows.Forms.RadioButton();
            this.gbTo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbToK = new System.Windows.Forms.RadioButton();
            this.rbToF = new System.Windows.Forms.RadioButton();
            this.rbToC = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTemperatura = new System.Windows.Forms.Label();
            this.gbFrom.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFrom
            // 
            this.gbFrom.Controls.Add(this.rbFromK);
            this.gbFrom.Controls.Add(this.rbFromF);
            this.gbFrom.Controls.Add(this.rbFromC);
            this.gbFrom.Controls.Add(this.gbTo);
            this.gbFrom.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFrom.Location = new System.Drawing.Point(41, 59);
            this.gbFrom.Name = "gbFrom";
            this.gbFrom.Size = new System.Drawing.Size(169, 176);
            this.gbFrom.TabIndex = 0;
            this.gbFrom.TabStop = false;
            // 
            // rbFromK
            // 
            this.rbFromK.AutoSize = true;
            this.rbFromK.Location = new System.Drawing.Point(15, 129);
            this.rbFromK.Name = "rbFromK";
            this.rbFromK.Size = new System.Drawing.Size(94, 29);
            this.rbFromK.TabIndex = 7;
            this.rbFromK.TabStop = true;
            this.rbFromK.Text = "Kelvin";
            this.rbFromK.UseVisualStyleBackColor = true;
            // 
            // rbFromF
            // 
            this.rbFromF.AutoSize = true;
            this.rbFromF.Location = new System.Drawing.Point(15, 81);
            this.rbFromF.Name = "rbFromF";
            this.rbFromF.Size = new System.Drawing.Size(142, 29);
            this.rbFromF.TabIndex = 6;
            this.rbFromF.TabStop = true;
            this.rbFromF.Text = "Fahrenheit";
            this.rbFromF.UseVisualStyleBackColor = true;
            // 
            // rbFromC
            // 
            this.rbFromC.AutoSize = true;
            this.rbFromC.Location = new System.Drawing.Point(15, 32);
            this.rbFromC.Name = "rbFromC";
            this.rbFromC.Size = new System.Drawing.Size(105, 29);
            this.rbFromC.TabIndex = 5;
            this.rbFromC.TabStop = true;
            this.rbFromC.Text = "Celsius";
            this.rbFromC.UseVisualStyleBackColor = true;
            // 
            // gbTo
            // 
            this.gbTo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTo.Location = new System.Drawing.Point(0, 239);
            this.gbTo.Name = "gbTo";
            this.gbTo.Size = new System.Drawing.Size(296, 204);
            this.gbTo.TabIndex = 4;
            this.gbTo.TabStop = false;
            this.gbTo.Text = "TO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(290, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatura:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(243, 100);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(223, 20);
            this.txtTemperatura.TabIndex = 2;
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.LightGray;
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnConverter.Image = ((System.Drawing.Image)(resources.GetObject("btnConverter.Image")));
            this.btnConverter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConverter.Location = new System.Drawing.Point(243, 134);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(223, 101);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbToK);
            this.groupBox1.Controls.Add(this.rbToF);
            this.groupBox1.Controls.Add(this.rbToC);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rbToK
            // 
            this.rbToK.AutoSize = true;
            this.rbToK.Location = new System.Drawing.Point(15, 128);
            this.rbToK.Name = "rbToK";
            this.rbToK.Size = new System.Drawing.Size(94, 29);
            this.rbToK.TabIndex = 7;
            this.rbToK.TabStop = true;
            this.rbToK.Text = "Kelvin";
            this.rbToK.UseVisualStyleBackColor = true;
            // 
            // rbToF
            // 
            this.rbToF.AutoSize = true;
            this.rbToF.Location = new System.Drawing.Point(15, 80);
            this.rbToF.Name = "rbToF";
            this.rbToF.Size = new System.Drawing.Size(142, 29);
            this.rbToF.TabIndex = 6;
            this.rbToF.TabStop = true;
            this.rbToF.Text = "Fahrenheit";
            this.rbToF.UseVisualStyleBackColor = true;
            // 
            // rbToC
            // 
            this.rbToC.AutoSize = true;
            this.rbToC.Location = new System.Drawing.Point(15, 32);
            this.rbToC.Name = "rbToC";
            this.rbToC.Size = new System.Drawing.Size(105, 29);
            this.rbToC.TabIndex = 5;
            this.rbToC.TabStop = true;
            this.rbToC.Text = "Celsius";
            this.rbToC.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 204);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TO:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "ORIGEM:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "DESTINO:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTemperatura
            // 
            this.lbTemperatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbTemperatura.Location = new System.Drawing.Point(243, 261);
            this.lbTemperatura.Name = "lbTemperatura";
            this.lbTemperatura.Size = new System.Drawing.Size(217, 200);
            this.lbTemperatura.TabIndex = 7;
            this.lbTemperatura.Text = "Resposta: ";
            this.lbTemperatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 521);
            this.Controls.Add(this.lbTemperatura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONVERSOR DE TEMPERATURA";
            this.gbFrom.ResumeLayout(false);
            this.gbFrom.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.GroupBox gbTo;
        private System.Windows.Forms.RadioButton rbFromC;
        private System.Windows.Forms.RadioButton rbFromK;
        private System.Windows.Forms.RadioButton rbFromF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbToK;
        private System.Windows.Forms.RadioButton rbToF;
        private System.Windows.Forms.RadioButton rbToC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTemperatura;
    }
}

