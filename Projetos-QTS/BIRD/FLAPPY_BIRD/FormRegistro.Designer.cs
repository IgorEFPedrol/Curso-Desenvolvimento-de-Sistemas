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
            this.SuspendLayout();
            // 
            // btnRegistrarProduto
            // 
            this.btnRegistrarProduto.Location = new System.Drawing.Point(292, 334);
            this.btnRegistrarProduto.Name = "btnRegistrarProduto";
            this.btnRegistrarProduto.Size = new System.Drawing.Size(225, 129);
            this.btnRegistrarProduto.TabIndex = 0;
            this.btnRegistrarProduto.Text = "Registrar Produto";
            this.btnRegistrarProduto.UseVisualStyleBackColor = true;
            this.btnRegistrarProduto.Click += new System.EventHandler(this.btnRegistrarProduto_Click);
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 531);
            this.Controls.Add(this.btnRegistrarProduto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarProduto;
    }
}