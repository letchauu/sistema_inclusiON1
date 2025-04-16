namespace sistema_inclusiON
{
    partial class frmBuscadeEscola
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
            this.txtBuscarEscolas = new System.Windows.Forms.TextBox();
            this.btnBuscarEscolas = new System.Windows.Forms.Button();
            this.dgvBuscadeEscolas = new System.Windows.Forms.DataGridView();
            this.btnExcluirEscola = new System.Windows.Forms.Button();
            this.btnEditarEscola = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscadeEscolas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Escolas";
            // 
            // txtBuscarEscolas
            // 
            this.txtBuscarEscolas.Location = new System.Drawing.Point(94, 106);
            this.txtBuscarEscolas.Name = "txtBuscarEscolas";
            this.txtBuscarEscolas.Size = new System.Drawing.Size(397, 20);
            this.txtBuscarEscolas.TabIndex = 1;
            // 
            // btnBuscarEscolas
            // 
            this.btnBuscarEscolas.Location = new System.Drawing.Point(529, 103);
            this.btnBuscarEscolas.Name = "btnBuscarEscolas";
            this.btnBuscarEscolas.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEscolas.TabIndex = 2;
            this.btnBuscarEscolas.Text = "Buscar";
            this.btnBuscarEscolas.UseVisualStyleBackColor = true;
            this.btnBuscarEscolas.Click += new System.EventHandler(this.btnBuscarEscolas_Click);
            // 
            // dgvBuscadeEscolas
            // 
            this.dgvBuscadeEscolas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscadeEscolas.Location = new System.Drawing.Point(0, 154);
            this.dgvBuscadeEscolas.Name = "dgvBuscadeEscolas";
            this.dgvBuscadeEscolas.Size = new System.Drawing.Size(809, 232);
            this.dgvBuscadeEscolas.TabIndex = 3;
            // 
            // btnExcluirEscola
            // 
            this.btnExcluirEscola.Location = new System.Drawing.Point(720, 103);
            this.btnExcluirEscola.Name = "btnExcluirEscola";
            this.btnExcluirEscola.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirEscola.TabIndex = 5;
            this.btnExcluirEscola.Text = "Excluir";
            this.btnExcluirEscola.UseVisualStyleBackColor = true;
            this.btnExcluirEscola.Click += new System.EventHandler(this.btnExcluirEscola_Click);
            // 
            // btnEditarEscola
            // 
            this.btnEditarEscola.Location = new System.Drawing.Point(626, 103);
            this.btnEditarEscola.Name = "btnEditarEscola";
            this.btnEditarEscola.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEscola.TabIndex = 6;
            this.btnEditarEscola.Text = "Editar";
            this.btnEditarEscola.UseVisualStyleBackColor = true;
            this.btnEditarEscola.Click += new System.EventHandler(this.btnEditarEscola_Click);
            // 
            // frmBuscadeEscola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 484);
            this.Controls.Add(this.btnEditarEscola);
            this.Controls.Add(this.btnExcluirEscola);
            this.Controls.Add(this.dgvBuscadeEscolas);
            this.Controls.Add(this.btnBuscarEscolas);
            this.Controls.Add(this.txtBuscarEscolas);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscadeEscola";
            this.Text = "Busca de Escolas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscadeEscolas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarEscolas;
        private System.Windows.Forms.Button btnBuscarEscolas;
        private System.Windows.Forms.DataGridView dgvBuscadeEscolas;
        private System.Windows.Forms.Button btnExcluirEscola;
        private System.Windows.Forms.Button btnEditarEscola;
    }
}