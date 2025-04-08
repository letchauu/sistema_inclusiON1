using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_inclusiON
{
    public partial class frmMenudeBusca: Form
    {
        public frmMenudeBusca()
        {
            InitializeComponent();
        }

        private void btnBuscarAlunos_Click(object sender, EventArgs e)
        {
            frmBuscadeAluno frm = new frmBuscadeAluno();
            frm.ShowDialog();
        }

        private void btnBuscarEscolas_Click(object sender, EventArgs e)
        {
            frmBuscadeEscola frm = new frmBuscadeEscola();
            frm.ShowDialog();
        }

        private void btnBuscasEstagiarios_Click(object sender, EventArgs e)
        {
            frmBuscadeEstagiario frm = new frmBuscadeEstagiario();
            frm.ShowDialog();
        }

        private void btnBuscarProfessores_Click(object sender, EventArgs e)
        {
            frmBuscadeProfessores frm = new frmBuscadeProfessores();
            frm.ShowDialog();
        }

        private void btnBuscarCuidadores_Click(object sender, EventArgs e)
        {
            frmBuscadeCuidadores frm = new frmBuscadeCuidadores();
            frm.ShowDialog();
        }

        private void btnSairBusca_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            frm.ShowDialog();
        }
    }
}
