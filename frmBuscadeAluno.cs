﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_inclusiON
{
    public partial class frmBuscadeAluno: Form
    {
        public frmBuscadeAluno()
        {
            InitializeComponent();
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                    {
                        cn.Open();
                        
                        var sqlQuery = "select * from alunos";        
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn)) 
                        {
                            using (DataTable dt = new DataTable())
                            
                            {
                                da.Fill(dt); 
                                dgvBuscadeAluno.DataSource = dt;
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);


                }
            }
        }

        private void btnSairBuscaAluno_Click(object sender, EventArgs e)
        {
            frmBuscadeAluno frm = new frmBuscadeAluno();
            frm.ShowDialog();
        }
    }
}
