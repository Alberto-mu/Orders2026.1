using Microsoft.AspNetCore.Mvc;
using Orders.Backend.UnitsOfWork.Interfaces;
using Orders.Shared.Entities;

namespace Orders.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : GenericController<Country>
    {
        public CountriesController(IGenericUnitOfWork<Country> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
