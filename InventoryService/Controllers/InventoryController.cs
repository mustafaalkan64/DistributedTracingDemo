using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        [HttpGet("check")]
        public IActionResult CheckInventory()
        {
            return Ok(new { inStock = true, quantity = 12 });
        }
    }
}
