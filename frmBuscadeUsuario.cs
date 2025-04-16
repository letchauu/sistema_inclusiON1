using System;
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
    public partial class frmBuscadeUsuario: Form
    {
        public frmBuscadeUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                    {
                        cn.Open();

                        var sqlQuery = "select * from usuarios";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())

                            {
                                da.Fill(dt);
                                dgvBuscadeUsuarios.DataSource = dt;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvBuscadeUsuarios.SelectedRows.Count > 0)
            {

                int idUsuario = Convert.ToInt32(dgvBuscadeUsuarios.SelectedRows[0].Cells["idUsuario"].Value);


                frmCadastrodeUsuario frm = new frmCadastrodeUsuario(idUsuario);
                frm.ShowDialog();


                BuscarNovamente();
            }
            else
            {
                MessageBox.Show("Selecione um usuário para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvBuscadeUsuarios.SelectedRows.Count > 0)
            {
                
                int idUsuario = Convert.ToInt32(dgvBuscadeUsuarios.SelectedRows[0].Cells["idUsuario"].Value);

                var confirm = MessageBox.Show("Tem certeza que deseja excluir esse usuário?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM usuarios WHERE idUsuario = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idUsuario);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Usuário excluído com sucesso!");
                                BuscarNovamente(); //regarrega a tabela após exclusão
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir usuário.\n\n" + ex.Message);
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
                    var sqlQuery = "select * from usuarios where nomeUsuario like '%" + txtBuscarUsuarios.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscadeUsuarios.DataSource = dt;
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

        
    
    
    

