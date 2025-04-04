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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            {
                txtLogin.BackColor = Color.SkyBlue;
            }
        }


        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtLogin.BackColor = Color.White;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.SkyBlue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação dos campos
                if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("Por favor, preencha ambos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLogin.Focus();
                    return;
                }
                // Autenticação
                if (AutenticarLogin(txtLogin.Text, txtSenha.Text))
                {
                    // Login bem-sucedido
                    this.Hide();
                    var frmMenuPrincipal = new frmMenuPrincipal();
                    frmMenuPrincipal.Show();
                }

                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", "Falha no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Clear();
                    txtLogin.Focus();
                    txtSenha.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            private bool AutenticarLogin(string usuario, string senha)
        {
            using (SqlConnection conn = new SqlConnection(conexao.IniciarCon))
            {
                string query = "SELECT idUsuario FROM usuarios WHERE nomeUsuario = @Usuario AND senhaUsuario = @Senha";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    conn.Open();
                    var result = cmd.ExecuteScalar();

                    // Se retornar um ID, o usuário existe e as credenciais estão corretas
                    return result != null && result != DBNull.Value;
                }
            }
        }
    }
}
        