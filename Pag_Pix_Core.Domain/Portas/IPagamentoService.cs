using Pag_Pix_Core.Domain.Entities;

namespace Pag_Pix_Core.Domain.Interfaces
{
    public interface IPagamentoService
    {
        Task Pagar(Pagamento pagamento);
        Task VerificarPagamento(Pagamento pagamento);
    }
}
