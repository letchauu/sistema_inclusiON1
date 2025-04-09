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
    public partial class frmMenuPrincipal: Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
           // frmAlunos frm = new frmAlunos();
            //frm.ShowDialog();
        }

        private void btnEscolas_Click(object sender, EventArgs e)
        {
            frmEscolas frm = new frmEscolas();
            frm.ShowDialog();
        }

        private void btnCuidadores_Click(object sender, EventArgs e)
        {
            frmCuidadores frm = new frmCuidadores();
            frm.ShowDialog();
        }

        private void btnEstagiarios_Click(object sender, EventArgs e)
        {
            frmEstagiarios frm = new frmEstagiarios();
            frm.ShowDialog();
        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            frmCadastroProfessor frm = new frmCadastroProfessor();
            frm.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmCadastrodeUsuario frm = new frmCadastrodeUsuario();
            frm.ShowDialog();
        }

        private void btnCadAlunos_Click(object sender, EventArgs e)
        {
            frmCadastrodeAlunoLaudado frm = new frmCadastrodeAlunoLaudado();
            frm.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmMenudeBusca frm = new frmMenudeBusca();
            frm.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            frmMenuRelatorios frm = new frmMenuRelatorios();
            frm.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }
}
