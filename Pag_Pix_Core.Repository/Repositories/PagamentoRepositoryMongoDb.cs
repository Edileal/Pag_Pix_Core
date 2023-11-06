using Pag_Pix_Core.Domain.Entities;
using Pag_Pix_Core.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag_Pix_Core.Repository.Repositories
{
    public class PagamentoRepositoryMongoDb : IPagamentoRepository
    {
        public Task BuscarPagamento(Pagamento pagamento)
        {
            throw new NotImplementedException();
        }

        public Task SalvarPagamento(Pagamento pagamento)
        {
            throw new NotImplementedException();
        }
    }
}
