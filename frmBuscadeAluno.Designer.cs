﻿namespace sistema_inclusiON
{
    partial class frmBuscadeAluno
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
            this.txtBuscarAluno = new System.Windows.Forms.TextBox();
            this.btnBuscarAluno = new System.Windows.Forms.Button();
            this.dgvBuscadeAluno = new System.Windows.Forms.DataGridView();
            this.btnSairBuscaAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscadeAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Aluno";
            // 
            // txtBuscarAluno
            // 
            this.txtBuscarAluno.Location = new System.Drawing.Point(75, 98);
            this.txtBuscarAluno.Name = "txtBuscarAluno";
            this.txtBuscarAluno.Size = new System.Drawing.Size(337, 20);
            this.txtBuscarAluno.TabIndex = 1;
            // 
            // btnBuscarAluno
            // 
            this.btnBuscarAluno.Location = new System.Drawing.Point(440, 98);
            this.btnBuscarAluno.Name = "btnBuscarAluno";
            this.btnBuscarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAluno.TabIndex = 2;
            this.btnBuscarAluno.Text = "Buscar";
            this.btnBuscarAluno.UseVisualStyleBackColor = true;
            // 
            // dgvBuscadeAluno
            // 
            this.dgvBuscadeAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscadeAluno.Location = new System.Drawing.Point(-2, 145);
            this.dgvBuscadeAluno.Name = "dgvBuscadeAluno";
            this.dgvBuscadeAluno.Size = new System.Drawing.Size(811, 270);
            this.dgvBuscadeAluno.TabIndex = 3;
            // 
            // btnSairBuscaAluno
            // 
            this.btnSairBuscaAluno.Location = new System.Drawing.Point(708, 432);
            this.btnSairBuscaAluno.Name = "btnSairBuscaAluno";
            this.btnSairBuscaAluno.Size = new System.Drawing.Size(75, 23);
            this.btnSairBuscaAluno.TabIndex = 4;
            this.btnSairBuscaAluno.Text = "Sair";
            this.btnSairBuscaAluno.UseVisualStyleBackColor = true;
            // 
            // frmBuscadeAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 481);
            this.Controls.Add(this.btnSairBuscaAluno);
            this.Controls.Add(this.dgvBuscadeAluno);
            this.Controls.Add(this.btnBuscarAluno);
            this.Controls.Add(this.txtBuscarAluno);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscadeAluno";
            this.Text = "Busca de Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscadeAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarAluno;
        private System.Windows.Forms.Button btnBuscarAluno;
        private System.Windows.Forms.DataGridView dgvBuscadeAluno;
        private System.Windows.Forms.Button btnSairBuscaAluno;
    }
}