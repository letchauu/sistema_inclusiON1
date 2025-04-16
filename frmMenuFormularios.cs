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
    public partial class frmMenuRelatorios: Form
    {
        public frmMenuRelatorios()
        {
            InitializeComponent();
        }

        private void btnAlunosLaudados_Click(object sender, EventArgs e)
        {
            DataTable alunos = BuscarAlunos();

            frmRelAlunos relatorio = new frmRelAlunos();
            relatorio.CarregarDados(alunos);
            relatorio.ShowDialog();
        }

        private DataTable BuscarAlunos()
        {
            string query = "SELECT idAluno, nomeAluno, emailPaisAluno FROM alunos";
            DataTable tabela = new DataTable();

            using (SqlConnection conn = new SqlConnection(conexao.IniciarCon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(tabela);
            }

            return tabela;
        }
    }
}
