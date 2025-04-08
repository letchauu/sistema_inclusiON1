namespace sistema_inclusiON
{
    partial class frmMenudeBusca
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
            this.btnBuscarAlunos = new System.Windows.Forms.Button();
            this.btnBuscarEscolas = new System.Windows.Forms.Button();
            this.btnBuscasEstagiarios = new System.Windows.Forms.Button();
            this.btnBuscarProfessores = new System.Windows.Forms.Button();
            this.btnBuscarCuidadores = new System.Windows.Forms.Button();
            this.btnSairBusca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscarAlunos
            // 
            this.btnBuscarAlunos.Location = new System.Drawing.Point(113, 177);
            this.btnBuscarAlunos.Name = "btnBuscarAlunos";
            this.btnBuscarAlunos.Size = new System.Drawing.Size(92, 23);
            this.btnBuscarAlunos.TabIndex = 0;
            this.btnBuscarAlunos.Text = "Buscar Alunos";
            this.btnBuscarAlunos.UseVisualStyleBackColor = true;
            this.btnBuscarAlunos.Click += new System.EventHandler(this.btnBuscarAlunos_Click);
            // 
            // btnBuscarEscolas
            // 
            this.btnBuscarEscolas.Location = new System.Drawing.Point(320, 177);
            this.btnBuscarEscolas.Name = "btnBuscarEscolas";
            this.btnBuscarEscolas.Size = new System.Drawing.Size(95, 23);
            this.btnBuscarEscolas.TabIndex = 1;
            this.btnBuscarEscolas.Text = "Buscar Escolas";
            this.btnBuscarEscolas.UseVisualStyleBackColor = true;
            this.btnBuscarEscolas.Click += new System.EventHandler(this.btnBuscarEscolas_Click);
            // 
            // btnBuscasEstagiarios
            // 
            this.btnBuscasEstagiarios.Location = new System.Drawing.Point(537, 177);
            this.btnBuscasEstagiarios.Name = "btnBuscasEstagiarios";
            this.btnBuscasEstagiarios.Size = new System.Drawing.Size(114, 23);
            this.btnBuscasEstagiarios.TabIndex = 2;
            this.btnBuscasEstagiarios.Text = "Buscar Estagiários";
            this.btnBuscasEstagiarios.UseVisualStyleBackColor = true;
            this.btnBuscasEstagiarios.Click += new System.EventHandler(this.btnBuscasEstagiarios_Click);
            // 
            // btnBuscarProfessores
            // 
            this.btnBuscarProfessores.Location = new System.Drawing.Point(113, 300);
            this.btnBuscarProfessores.Name = "btnBuscarProfessores";
            this.btnBuscarProfessores.Size = new System.Drawing.Size(114, 23);
            this.btnBuscarProfessores.TabIndex = 3;
            this.btnBuscarProfessores.Text = "Buscar Professores";
            this.btnBuscarProfessores.UseVisualStyleBackColor = true;
            this.btnBuscarProfessores.Click += new System.EventHandler(this.btnBuscarProfessores_Click);
            // 
            // btnBuscarCuidadores
            // 
            this.btnBuscarCuidadores.Location = new System.Drawing.Point(309, 300);
            this.btnBuscarCuidadores.Name = "btnBuscarCuidadores";
            this.btnBuscarCuidadores.Size = new System.Drawing.Size(115, 23);
            this.btnBuscarCuidadores.TabIndex = 4;
            this.btnBuscarCuidadores.Text = "Buscar Cuidadores";
            this.btnBuscarCuidadores.UseVisualStyleBackColor = true;
            this.btnBuscarCuidadores.Click += new System.EventHandler(this.btnBuscarCuidadores_Click);
            // 
            // btnSairBusca
            // 
            this.btnSairBusca.Location = new System.Drawing.Point(647, 415);
            this.btnSairBusca.Name = "btnSairBusca";
            this.btnSairBusca.Size = new System.Drawing.Size(75, 23);
            this.btnSairBusca.TabIndex = 5;
            this.btnSairBusca.Text = "Sair";
            this.btnSairBusca.UseVisualStyleBackColor = true;
            this.btnSairBusca.Click += new System.EventHandler(this.btnSairBusca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // frmMenudeBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSairBusca);
            this.Controls.Add(this.btnBuscarCuidadores);
            this.Controls.Add(this.btnBuscarProfessores);
            this.Controls.Add(this.btnBuscasEstagiarios);
            this.Controls.Add(this.btnBuscarEscolas);
            this.Controls.Add(this.btnBuscarAlunos);
            this.Name = "frmMenudeBusca";
            this.Text = "Menu de Buscas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarAlunos;
        private System.Windows.Forms.Button btnBuscarEscolas;
        private System.Windows.Forms.Button btnBuscasEstagiarios;
        private System.Windows.Forms.Button btnBuscarProfessores;
        private System.Windows.Forms.Button btnBuscarCuidadores;
        private System.Windows.Forms.Button btnSairBusca;
        private System.Windows.Forms.Label label1;
    }
}