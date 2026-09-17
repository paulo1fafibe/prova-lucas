using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja_Brinquedos_Avaliacao.Models;
using static Loja_Brinquedos_Avaliacao.Models.Brinquedo;

namespace Loja_Brinquedos_Avaliacao.Controllers
{
    public class ControllerBrinquedo
    {
        BrinquedoLista listaBrinquedo = new BrinquedoLista();

        public void Adicionar(Brinquedo brinquedo)
        {
            listaBrinquedo.Add(brinquedo);
        }

        public void Remover(Brinquedo brinquedo)
        {
            listaBrinquedo.Remove(brinquedo);
        }

        public List<Brinquedo> ListarBrinquedo()
        {
            return listaBrinquedo;
        }

    }
}
