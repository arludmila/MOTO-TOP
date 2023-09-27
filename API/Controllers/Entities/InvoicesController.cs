using Business;
using Contracts.DTOs.Entities;
using Entities.Core;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : BaseController<Invoice, InvoiceDto>
    {
        public InvoicesController(GenericService<Invoice> service) : base(service)
        {
        }
    }
}
