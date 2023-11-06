using Pag_Pix_Core.Domain.Entities;
using Pag_Pix_Core.Domain.Interfaces;
using Pag_Pix_Core.Repository.Adaptadores.Context;

namespace Pag_Pix_Core.Repository.Adaptadores.Repositories
{
    public class PagamentoRepositoryMysql : IPagamentoRepository
    {
        private readonly AppDbContext _context;

        public PagamentoRepositoryMysql(AppDbContext context)
        {
            _context = context;
        }

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
