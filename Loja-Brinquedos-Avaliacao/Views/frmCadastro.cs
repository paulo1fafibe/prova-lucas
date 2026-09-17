using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja_Brinquedos_Avaliacao.Models;
using Loja_Brinquedos_Avaliacao.Controllers;

namespace Loja_Brinquedos_Avaliacao.Views
{

    public partial class frmCadastro : Form
    {

        ControllerBrinquedo controllerBrinquedo = new ControllerBrinquedo();
        ControllerFabricante controllerFabricante = new ControllerFabricante();
        ControllerProduto controllerProduto = new ControllerProduto();

        public frmCadastro()
        {
            InitializeComponent();
        }

        void AdicionarCadastro()
        {


            Brinquedo brinquedo = new Brinquedo();
            Fabricante fabricante = new Fabricante();
            Produto produto = new Produto();

            fabricante.Nome = txtNome.Text;
            fabricante.CNPJ = txtCNPJ.Text;

            produto.CodigoBarras = txtCodigoBarras.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Preco = double.Parse(txtPreco.Text);
            brinquedo.Categoria = txtCategoria.Text;
            brinquedo.IdadeMinima = int.Parse(txtIdadeMin.Text);

        }

        void AtualizarCadastro()
        {
            lstLista.DataSource = null;

            lstLista.DataSource = controllerBrinquedo.ListarBrinquedo();

            lstLista.DisplayMember = "CBDCeNomeFabricante";


        }

        void RemoverCadastro()
        {
            

            AtualizarCadastro();

        }

        

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AdicionarCadastro();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverCadastro();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmTelaVisuBrinquedos frm2 = new frmTelaVisuBrinquedos();
            frm2.Show();
        }
    }
}
