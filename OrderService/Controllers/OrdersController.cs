using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private static readonly ActivitySource ActivitySource = new("OrderService");

        public OrderController(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder()
        {
            using var activity = ActivitySource.StartActivity("CreateOrder");

            // Inventory çağrısı
            var inventoryResponse = await _httpClient.GetAsync("http://localhost:5002/api/inventory/check");
            var inventoryStatus = await inventoryResponse.Content.ReadAsStringAsync();
            activity?.AddTag("inventory.response", inventoryStatus);

            // Payment çağrısı
            var paymentResponse = await _httpClient.PostAsync("http://localhost:5003/api/payment", null);
            var paymentStatus = await paymentResponse.Content.ReadAsStringAsync();
            activity?.AddTag("payment.response", paymentStatus);

            return Ok(new { order = "created", inventory = inventoryStatus, payment = paymentStatus });
        }
    }
}
