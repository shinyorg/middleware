using System;
using System.Threading.Tasks;


namespace Shiny.Middleware.Transfers
{
    public interface IUploadProcessor
    {
        Task<IActionResult> Process(HttpContext context);
    }
}
