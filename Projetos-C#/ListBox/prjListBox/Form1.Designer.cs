namespace prjListBox
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.ListBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(239, 26);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Peso:";
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 16;
            this.lista.Location = new System.Drawing.Point(14, 153);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(428, 340);
            this.lista.TabIndex = 2;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(13, 53);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(138, 23);
            this.txtPeso.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione uma Unidade:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.Color.Red;
            this.btnLimpar.Location = new System.Drawing.Point(346, 26);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 50);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(239, 87);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 50);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.ForeColor = System.Drawing.Color.Red;
            this.btnRemover.Location = new System.Drawing.Point(346, 86);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(96, 50);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(473, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 110);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resposta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(476, 163);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 50);
            this.button3.TabIndex = 9;
            this.button3.Text = "Somar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(476, 253);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 50);
            this.button4.TabIndex = 10;
            this.button4.Text = "Média";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(476, 343);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 50);
            this.button5.TabIndex = 11;
            this.button5.Text = "Maior";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(476, 443);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 50);
            this.button6.TabIndex = 12;
            this.button6.Text = "Menor";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 540);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "CÁLCULO DA FORÇA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

