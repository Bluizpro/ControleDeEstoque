using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmModeloDeCadastro : Form
    {
        public String operacao;
        public frmModeloDeCadastro()
        {
            InitializeComponent();
        }
        public void alteraBotoes(int op)
        {
            //op = operacoes que serao feitas com os botoes
            // 1 = Preparar os botoes para inserir e localizar
            // 2 = preparar os para inserir/alterar um registro
            // 3 = preparar a tela para excluir ou alterar

            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;


            if (op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;

            }
        }

        private void frmModeloDeCadastro_Load(object sender, EventArgs e)
        {

        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}

