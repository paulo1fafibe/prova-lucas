using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_Brinquedos_Avaliacao.Models
{
    public class Produto : Fabricante
    {
        public string CodigoBarras { get; set; }
        public string Descricao { get; set; }
        public Double Preco { get; set; }

        public string CodigoBarraDescricao
        {
            get
            {
                return CodigoBarras + " - " + Descricao;
            }
        }

        public class ProdutoLista : List<Produto>
        {

        }
    }
}
