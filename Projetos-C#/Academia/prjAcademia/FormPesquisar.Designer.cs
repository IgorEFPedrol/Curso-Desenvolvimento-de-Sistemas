﻿namespace prjAcademia
{
    partial class FormPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisar));
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.rbMeio = new System.Windows.Forms.RadioButton();
            this.rbFim = new System.Windows.Forms.RadioButton();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnAbrirFicha = new System.Windows.Forms.Button();
            this.pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(133)))), ((int)(((byte)(181)))));
            this.pnSuperior.Controls.Add(this.rbFim);
            this.pnSuperior.Controls.Add(this.rbMeio);
            this.pnSuperior.Controls.Add(this.rbInicio);
            this.pnSuperior.Controls.Add(this.btnPesquisar);
            this.pnSuperior.Controls.Add(this.txtNome);
            this.pnSuperior.Controls.Add(this.label1);
            this.pnSuperior.Location = new System.Drawing.Point(12, 12);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(550, 109);
            this.pnSuperior.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(27, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(356, 11);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(175, 86);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "PESQUISAR FICHA";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // rbInicio
            // 
            this.rbInicio.AutoSize = true;
            this.rbInicio.Checked = true;
            this.rbInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbInicio.ForeColor = System.Drawing.Color.White;
            this.rbInicio.Location = new System.Drawing.Point(25, 76);
            this.rbInicio.Name = "rbInicio";
            this.rbInicio.Size = new System.Drawing.Size(65, 21);
            this.rbInicio.TabIndex = 3;
            this.rbInicio.TabStop = true;
            this.rbInicio.Text = "INÍCIO";
            this.rbInicio.UseVisualStyleBackColor = true;
            // 
            // rbMeio
            // 
            this.rbMeio.AutoSize = true;
            this.rbMeio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbMeio.ForeColor = System.Drawing.Color.White;
            this.rbMeio.Location = new System.Drawing.Point(140, 76);
            this.rbMeio.Name = "rbMeio";
            this.rbMeio.Size = new System.Drawing.Size(60, 21);
            this.rbMeio.TabIndex = 4;
            this.rbMeio.Text = "MEIO";
            this.rbMeio.UseVisualStyleBackColor = true;
            // 
            // rbFim
            // 
            this.rbFim.AutoSize = true;
            this.rbFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbFim.ForeColor = System.Drawing.Color.White;
            this.rbFim.Location = new System.Drawing.Point(263, 76);
            this.rbFim.Name = "rbFim";
            this.rbFim.Size = new System.Drawing.Size(48, 21);
            this.rbFim.TabIndex = 5;
            this.rbFim.Text = "FIM";
            this.rbFim.UseVisualStyleBackColor = true;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(12, 139);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(549, 338);
            this.dgvLista.TabIndex = 1;
            this.dgvLista.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_RowEnter);
            // 
            // btnAbrirFicha
            // 
            this.btnAbrirFicha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirFicha.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirFicha.Image")));
            this.btnAbrirFicha.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbrirFicha.Location = new System.Drawing.Point(3, 483);
            this.btnAbrirFicha.Name = "btnAbrirFicha";
            this.btnAbrirFicha.Size = new System.Drawing.Size(567, 76);
            this.btnAbrirFicha.TabIndex = 3;
            this.btnAbrirFicha.Text = "ABRIR A FICHA SELECIONADA";
            this.btnAbrirFicha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirFicha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirFicha.UseVisualStyleBackColor = true;
            this.btnAbrirFicha.Click += new System.EventHandler(this.btnAbrirFicha_Click);
            // 
            // FormPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(574, 561);
            this.Controls.Add(this.btnAbrirFicha);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.pnSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesquisar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PESQUISAR";
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFim;
        private System.Windows.Forms.RadioButton rbMeio;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnAbrirFicha;
    }
}