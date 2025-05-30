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
    public partial class frmBuscadeEstagiario: Form
    {
        public frmBuscadeEstagiario()
        {
            InitializeComponent();
        }

        private void btnBuscarEstagiario_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                    {
                        cn.Open();

                        var sqlQuery = "select * from estagiarios";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())

                            {
                                da.Fill(dt);
                                dgvBuscadeEstagiarios.DataSource = dt;
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

        private void btnSairBuscaEstagiario_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvBuscadeEstagiarios.SelectedRows.Count > 0)
            {

                int idEstagiario = Convert.ToInt32(dgvBuscadeEstagiarios.SelectedRows[0].Cells["idEstagiario"].Value);


                frmEstagiarios frm = new frmEstagiarios(idEstagiario);
                frm.ShowDialog();


                BuscarNovamente();
            }
            else
            {
                MessageBox.Show("Selecione um estagiário(a) para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvBuscadeEstagiarios.SelectedRows.Count > 0)
            {
                
                int idEstagiario = Convert.ToInt32(dgvBuscadeEstagiarios.SelectedRows[0].Cells["idEstagiario"].Value);

                var confirm = MessageBox.Show("Tem certeza que deseja excluir esse estagiário(a)?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM estagiarios WHERE idEstagiario = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idEstagiario);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Estagiário(a) excluído(a) com sucesso!");
                                BuscarNovamente(); //regarrega a tabela após exclusão
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir estagiário(a).\n\n" + ex.Message);
                    }
                }
            }
        }
        private void BuscarNovamente()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sqlQuery = "select * from estagiarios where nomeEstagiario like '%" + txtBuscarEstagiario.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscadeEstagiarios.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados.\n\n" + ex.Message);
            }
        }
    }
}
       
    
    

