using System;
using System.Threading.Tasks;


namespace Shiny.Middleware.Transfers
{
    public interface IDownloadProcessor
    {
        Task<IActionResult> Process(HttpContext context);
    }
}
