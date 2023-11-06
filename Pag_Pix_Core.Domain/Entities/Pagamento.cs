using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag_Pix_Core.Domain.Entities
{
    public class Pagamento
    {
        public Guid Id { get; set; }
        public DateTime diasPesquisa { get; set; }
        public Pagador pagador { get; set; }
        public Recebedor recebedor { get; set; }
        public decimal valor { get; set; }
    }
}
