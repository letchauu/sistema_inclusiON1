namespace sistema_inclusiON
{
    partial class frmBuscadeProfessores
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
            this.txtBuscarProfessor = new System.Windows.Forms.TextBox();
            this.btnBuscarProfessor = new System.Windows.Forms.Button();
            this.btnSairBuscaProfessor = new System.Windows.Forms.Button();
            this.dgvBuscadeProfessor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscadeProfessor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Professor";
            // 
            // txtBuscarProfessor
            // 
            this.txtBuscarProfessor.Location = new System.Drawing.Point(94, 110);
            this.txtBuscarProfessor.Name = "txtBuscarProfessor";
            this.txtBuscarProfessor.Size = new System.Drawing.Size(382, 20);
            this.txtBuscarProfessor.TabIndex = 1;
            // 
            // btnBuscarProfessor
            // 
            this.btnBuscarProfessor.Location = new System.Drawing.Point(498, 107);
            this.btnBuscarProfessor.Name = "btnBuscarProfessor";
            this.btnBuscarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProfessor.TabIndex = 2;
            this.btnBuscarProfessor.Text = "Buscar";
            this.btnBuscarProfessor.UseVisualStyleBackColor = true;
            this.btnBuscarProfessor.Click += new System.EventHandler(this.btnBuscarProfessor_Click);
            // 
            // btnSairBuscaProfessor
            // 
            this.btnSairBuscaProfessor.Location = new System.Drawing.Point(712, 451);
            this.btnSairBuscaProfessor.Name = "btnSairBuscaProfessor";
            this.btnSairBuscaProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnSairBuscaProfessor.TabIndex = 3;
            this.btnSairBuscaProfessor.Text = "Sair";
            this.btnSairBuscaProfessor.UseVisualStyleBackColor = true;
            this.btnSairBuscaProfessor.Click += new System.EventHandler(this.btnSairBuscaProfessor_Click);
            // 
            // dgvBuscadeProfessor
            // 
            this.dgvBuscadeProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscadeProfessor.Location = new System.Drawing.Point(-1, 150);
            this.dgvBuscadeProfessor.Name = "dgvBuscadeProfessor";
            this.dgvBuscadeProfessor.Size = new System.Drawing.Size(816, 279);
            this.dgvBuscadeProfessor.TabIndex = 4;
            // 
            // frmBuscadeProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 486);
            this.Controls.Add(this.dgvBuscadeProfessor);
            this.Controls.Add(this.btnSairBuscaProfessor);
            this.Controls.Add(this.btnBuscarProfessor);
            this.Controls.Add(this.txtBuscarProfessor);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscadeProfessores";
            this.Text = "Busca de Professores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscadeProfessor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarProfessor;
        private System.Windows.Forms.Button btnBuscarProfessor;
        private System.Windows.Forms.Button btnSairBuscaProfessor;
        private System.Windows.Forms.DataGridView dgvBuscadeProfessor;
    }
}