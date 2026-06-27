using Oid85.PrintTemplate.Application.Interfaces.Services;
using Oid85.PrintTemplate.Core.Requests;
using Oid85.PrintTemplate.Core.Responses;

namespace Oid85.PrintTemplate.Application.Services
{
    public class PrintTemplateService : IPrintTemplateService
    {
        public Task<CreatePrintTemplateResponse> CreatePrintTemplateAsync(CreatePrintTemplateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
