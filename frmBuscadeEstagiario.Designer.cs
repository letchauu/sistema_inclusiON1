﻿namespace sistema_inclusiON
{
    partial class frmBuscadeEstagiario
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
            this.txtBuscarEstagiario = new System.Windows.Forms.TextBox();
            this.btnBuscarEstagiario = new System.Windows.Forms.Button();
            this.dgvBuscadeEstagiarios = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscadeEstagiarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Estagiário";
            // 
            // txtBuscarEstagiario
            // 
            this.txtBuscarEstagiario.Location = new System.Drawing.Point(99, 86);
            this.txtBuscarEstagiario.Name = "txtBuscarEstagiario";
            this.txtBuscarEstagiario.Size = new System.Drawing.Size(350, 20);
            this.txtBuscarEstagiario.TabIndex = 1;
            // 
            // btnBuscarEstagiario
            // 
            this.btnBuscarEstagiario.Location = new System.Drawing.Point(476, 84);
            this.btnBuscarEstagiario.Name = "btnBuscarEstagiario";
            this.btnBuscarEstagiario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEstagiario.TabIndex = 2;
            this.btnBuscarEstagiario.Text = "Buscar";
            this.btnBuscarEstagiario.UseVisualStyleBackColor = true;
            this.btnBuscarEstagiario.Click += new System.EventHandler(this.btnBuscarEstagiario_Click);
            // 
            // dgvBuscadeEstagiarios
            // 
            this.dgvBuscadeEstagiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscadeEstagiarios.Location = new System.Drawing.Point(1, 141);
            this.dgvBuscadeEstagiarios.Name = "dgvBuscadeEstagiarios";
            this.dgvBuscadeEstagiarios.Size = new System.Drawing.Size(803, 224);
            this.dgvBuscadeEstagiarios.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(581, 84);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(691, 86);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmBuscadeEstagiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 461);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvBuscadeEstagiarios);
            this.Controls.Add(this.btnBuscarEstagiario);
            this.Controls.Add(this.txtBuscarEstagiario);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscadeEstagiario";
            this.Text = "Busca de Estagiarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscadeEstagiarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarEstagiario;
        private System.Windows.Forms.Button btnBuscarEstagiario;
        private System.Windows.Forms.DataGridView dgvBuscadeEstagiarios;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
    }
}