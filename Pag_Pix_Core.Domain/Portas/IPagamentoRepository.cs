using Pag_Pix_Core.Domain.Entities;

namespace Pag_Pix_Core.Domain.Interfaces
{
    public interface IPagamentoRepository
    {
        Task SalvarPagamento(Pagamento pagamento);
        Task BuscarPagamento(Pagamento pagamento);
    }
}
