namespace FLAPPY_BIRD
{
    partial class FormRegistro
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
            this.btnRegistrarProduto = new System.Windows.Forms.Button();
            this.labelSerial = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistrarProduto
            // 
            this.btnRegistrarProduto.BackColor = System.Drawing.Color.Tan;
            this.btnRegistrarProduto.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Italic);
            this.btnRegistrarProduto.ForeColor = System.Drawing.Color.Gold;
            this.btnRegistrarProduto.Location = new System.Drawing.Point(169, 209);
            this.btnRegistrarProduto.Name = "btnRegistrarProduto";
            this.btnRegistrarProduto.Size = new System.Drawing.Size(310, 99);
            this.btnRegistrarProduto.TabIndex = 0;
            this.btnRegistrarProduto.Text = "Registrar Produto";
            this.btnRegistrarProduto.UseVisualStyleBackColor = false;
            this.btnRegistrarProduto.Click += new System.EventHandler(this.btnRegistrarProduto_Click);
            // 
            // labelSerial
            // 
            this.labelSerial.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Italic);
            this.labelSerial.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelSerial.Location = new System.Drawing.Point(186, 42);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(281, 94);
            this.labelSerial.TabIndex = 1;
            this.labelSerial.Text = "Serial";
            this.labelSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(135, 137);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(378, 20);
            this.txtSerial.TabIndex = 2;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(625, 399);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.labelSerial);
            this.Controls.Add(this.btnRegistrarProduto);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarProduto;
        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.TextBox txtSerial;
    }
}