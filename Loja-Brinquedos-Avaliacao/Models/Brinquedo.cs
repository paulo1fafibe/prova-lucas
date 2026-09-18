using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//boa neguin

//teste 2
namespace Loja_Brinquedos_Avaliacao.Models
{
    public class Brinquedo : Produto
    {
        public string Categoria { get; set; }
        public int IdadeMinima { get; set; }

        public string CBDeCategoria
        {
            get
            {
                return CodigoBarraDescricao + " - " + Categoria;
            }

        }

        public string CBDCeNomeFabricante
        {
            get
            { return CBDeCategoria + " - " + Nome; }
        }

        public class BrinquedoLista : List<Brinquedo>
        {

        }

        
    }

    
}

//teste viado

//teste viado
//teste viado
//teste viado
//teste viado
//teste viado
//teste viado
//teste viado
//teste viado
//teste viado
//teste viado
//teste viado
//teste viado

//teste viado