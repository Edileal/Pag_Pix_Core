using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pag_Pix_Core.Domain.Interfaces
{
    public interface IUseCase<TRequest, TResponse> where TRequest : class where TResponse : class
    {
        Task Execute(TRequest request);
    }
}
