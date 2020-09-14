using System;
using System.Threading.Tasks;


namespace Shiny.Middleware.Transfers
{
    public interface ITransferProcessor
    {
        Task<IActionResult> Upload(IHttpContext context);
        Task<IActionResult> Download(IHttpContext context);
    }
}
