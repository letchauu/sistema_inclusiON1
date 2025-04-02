namespace sistema_inclusiON
{
    partial class frmMenuRelatorios
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
            this.btnAlunosLaudados = new System.Windows.Forms.Button();
            this.btnCids = new System.Windows.Forms.Button();
            this.btnEscolas = new System.Windows.Forms.Button();
            this.btnCuidadores = new System.Windows.Forms.Button();
            this.btnEstagiarios = new System.Windows.Forms.Button();
            this.btnProfessores = new System.Windows.Forms.Button();
            this.btnSairMenuRel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlunosLaudados
            // 
            this.btnAlunosLaudados.Location = new System.Drawing.Point(88, 69);
            this.btnAlunosLaudados.Name = "btnAlunosLaudados";
            this.btnAlunosLaudados.Size = new System.Drawing.Size(100, 38);
            this.btnAlunosLaudados.TabIndex = 0;
            this.btnAlunosLaudados.Text = "Alunos Laudados";
            this.btnAlunosLaudados.UseVisualStyleBackColor = true;
            this.btnAlunosLaudados.Click += new System.EventHandler(this.btnAlunosLaudados_Click);
            // 
            // btnCids
            // 
            this.btnCids.Location = new System.Drawing.Point(248, 69);
            this.btnCids.Name = "btnCids";
            this.btnCids.Size = new System.Drawing.Size(100, 37);
            this.btnCids.TabIndex = 1;
            this.btnCids.Text = "CID\'s";
            this.btnCids.UseVisualStyleBackColor = true;
            // 
            // btnEscolas
            // 
            this.btnEscolas.Location = new System.Drawing.Point(424, 70);
            this.btnEscolas.Name = "btnEscolas";
            this.btnEscolas.Size = new System.Drawing.Size(100, 37);
            this.btnEscolas.TabIndex = 2;
            this.btnEscolas.Text = "Escolas";
            this.btnEscolas.UseVisualStyleBackColor = true;
            // 
            // btnCuidadores
            // 
            this.btnCuidadores.Location = new System.Drawing.Point(88, 151);
            this.btnCuidadores.Name = "btnCuidadores";
            this.btnCuidadores.Size = new System.Drawing.Size(100, 37);
            this.btnCuidadores.TabIndex = 3;
            this.btnCuidadores.Text = "Cuidadores";
            this.btnCuidadores.UseVisualStyleBackColor = true;
            // 
            // btnEstagiarios
            // 
            this.btnEstagiarios.Location = new System.Drawing.Point(248, 153);
            this.btnEstagiarios.Name = "btnEstagiarios";
            this.btnEstagiarios.Size = new System.Drawing.Size(100, 35);
            this.btnEstagiarios.TabIndex = 4;
            this.btnEstagiarios.Text = "Estagiários";
            this.btnEstagiarios.UseVisualStyleBackColor = true;
            // 
            // btnProfessores
            // 
            this.btnProfessores.Location = new System.Drawing.Point(424, 151);
            this.btnProfessores.Name = "btnProfessores";
            this.btnProfessores.Size = new System.Drawing.Size(100, 35);
            this.btnProfessores.TabIndex = 5;
            this.btnProfessores.Text = "Professores";
            this.btnProfessores.UseVisualStyleBackColor = true;
            // 
            // btnSairMenuRel
            // 
            this.btnSairMenuRel.Location = new System.Drawing.Point(601, 369);
            this.btnSairMenuRel.Name = "btnSairMenuRel";
            this.btnSairMenuRel.Size = new System.Drawing.Size(111, 43);
            this.btnSairMenuRel.TabIndex = 6;
            this.btnSairMenuRel.Text = "Sair";
            this.btnSairMenuRel.UseVisualStyleBackColor = true;
            // 
            // frmMenuRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSairMenuRel);
            this.Controls.Add(this.btnProfessores);
            this.Controls.Add(this.btnEstagiarios);
            this.Controls.Add(this.btnCuidadores);
            this.Controls.Add(this.btnEscolas);
            this.Controls.Add(this.btnCids);
            this.Controls.Add(this.btnAlunosLaudados);
            this.Name = "frmMenuRelatorios";
            this.Text = "Menu Relatorios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlunosLaudados;
        private System.Windows.Forms.Button btnCids;
        private System.Windows.Forms.Button btnEscolas;
        private System.Windows.Forms.Button btnCuidadores;
        private System.Windows.Forms.Button btnEstagiarios;
        private System.Windows.Forms.Button btnProfessores;
        private System.Windows.Forms.Button btnSairMenuRel;
    }
}