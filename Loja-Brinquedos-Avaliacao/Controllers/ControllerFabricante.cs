using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja_Brinquedos_Avaliacao.Models;
using static Loja_Brinquedos_Avaliacao.Fabricante;
using static Loja_Brinquedos_Avaliacao.Models.Brinquedo;

namespace Loja_Brinquedos_Avaliacao.Controllers
{
    public class ControllerFabricante
    {

        FabricanteLista listaFabricante = new FabricanteLista();

        public void Adicionar(Fabricante fabricante)
        {
            listaFabricante.Add(fabricante);
        }

        public void Remover(Fabricante fabricante)
        {
            listaFabricante.Remove(fabricante);
        }

        public List<Fabricante> ListarFabricante()
        {
            return listaFabricante;
        }

    }
}
