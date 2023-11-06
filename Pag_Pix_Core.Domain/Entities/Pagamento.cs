using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag_Pix_Core.Domain.Entities
{
    public class Pagamento
    {
        public DateTime diasPesquisa;
        public Pagador pagador;
        public Recebedor recebedor;
        public decimal valor;
    }
}
