namespace sistema_inclusiON
{
    partial class frmBuscadeCuidadores
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
            this.txtBuscarCuidador = new System.Windows.Forms.TextBox();
            this.btnBuscarCuidador = new System.Windows.Forms.Button();
            this.btnSairBuscaCuidador = new System.Windows.Forms.Button();
            this.dgvBuscarCuidador = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCuidador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Cuidador";
            // 
            // txtBuscarCuidador
            // 
            this.txtBuscarCuidador.Location = new System.Drawing.Point(65, 100);
            this.txtBuscarCuidador.Name = "txtBuscarCuidador";
            this.txtBuscarCuidador.Size = new System.Drawing.Size(400, 20);
            this.txtBuscarCuidador.TabIndex = 1;
            // 
            // btnBuscarCuidador
            // 
            this.btnBuscarCuidador.Location = new System.Drawing.Point(496, 98);
            this.btnBuscarCuidador.Name = "btnBuscarCuidador";
            this.btnBuscarCuidador.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCuidador.TabIndex = 2;
            this.btnBuscarCuidador.Text = "Buscar";
            this.btnBuscarCuidador.UseVisualStyleBackColor = true;
            this.btnBuscarCuidador.Click += new System.EventHandler(this.btnBuscarCuidador_Click);
            // 
            // btnSairBuscaCuidador
            // 
            this.btnSairBuscaCuidador.Location = new System.Drawing.Point(701, 472);
            this.btnSairBuscaCuidador.Name = "btnSairBuscaCuidador";
            this.btnSairBuscaCuidador.Size = new System.Drawing.Size(75, 23);
            this.btnSairBuscaCuidador.TabIndex = 3;
            this.btnSairBuscaCuidador.Text = "Sair";
            this.btnSairBuscaCuidador.UseVisualStyleBackColor = true;
            this.btnSairBuscaCuidador.Click += new System.EventHandler(this.btnSairBuscaCuidador_Click);
            // 
            // dgvBuscarCuidador
            // 
            this.dgvBuscarCuidador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCuidador.Location = new System.Drawing.Point(1, 145);
            this.dgvBuscarCuidador.Name = "dgvBuscarCuidador";
            this.dgvBuscarCuidador.Size = new System.Drawing.Size(813, 264);
            this.dgvBuscarCuidador.TabIndex = 4;
            // 
            // frmBuscadeCuidadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 516);
            this.Controls.Add(this.dgvBuscarCuidador);
            this.Controls.Add(this.btnSairBuscaCuidador);
            this.Controls.Add(this.btnBuscarCuidador);
            this.Controls.Add(this.txtBuscarCuidador);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscadeCuidadores";
            this.Text = "Busca de Cuidadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCuidador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarCuidador;
        private System.Windows.Forms.Button btnBuscarCuidador;
        private System.Windows.Forms.Button btnSairBuscaCuidador;
        private System.Windows.Forms.DataGridView dgvBuscarCuidador;
    }
}