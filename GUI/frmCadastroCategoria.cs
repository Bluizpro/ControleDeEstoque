using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using DAL;
using BBL;

namespace GUI
{
    public partial class frmCadastroCategoria : Form
    {
        public String operacao;
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtcodigo.Clear();
            txtNome.Clear();
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

        private void frmCadastroCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try { 
            ModeloCategoria modelo = new ModeloCategoria();
            modelo.CatNome = txtNome.Text;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            if (this.operacao == "inserir")
            {
                // cadastrar uma categoria
                bll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado: Codigo " + modelo.CatCod.ToString());
            }
            else
            {
                // alterar uma categoria
                modelo.CatCod = Convert.ToInt32(txtcodigo.Text);
                bll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado");
            }
                this.LimpaTela();
                this.alteraBotoes(1);
            
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
    }
}
