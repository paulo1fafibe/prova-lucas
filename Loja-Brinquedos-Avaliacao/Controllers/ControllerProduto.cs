using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja_Brinquedos_Avaliacao.Models;
using static Loja_Brinquedos_Avaliacao.Models.Brinquedo;
using static Loja_Brinquedos_Avaliacao.Models.Produto;

namespace Loja_Brinquedos_Avaliacao.Controllers
{
    internal class ControllerProduto
    {

        ProdutoLista listaProduto = new ProdutoLista();
        public void Adicionar(Produto produto)
        {
            listaProduto.Add(produto);
        }

        public void Remover(Produto produto)
        {
            listaProduto.Remove(produto);
        }

        public List<Produto> ListarProduto()
        {
            return listaProduto;
        }

    }
}
