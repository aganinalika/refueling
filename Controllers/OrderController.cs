using Microsoft.AspNetCore.Mvc;
using refueling.Domain;
using refueling.Repository;

namespace refueling.Controllers
{
    [ApiController]
    [Route("/order")]
    public class OrderController : ControllerBase
    {
        [HttpPut]
        public Order Create(Order order)
        {
            Storage.OrderStorage.Create(order);
            return order;
        }

        [HttpGet]
        public Order Read(int orderId)
        {
            return Storage.OrderStorage.Read(orderId);;
        }

        [HttpPatch]
        public Order Update(int orderId, Order neworder)
        {
            return Storage.OrderStorage.Update(orderId, neworder);
        }

        [HttpDelete]
        public bool Delete(int orderId)
        {
            return Storage.OrderStorage.Delete(orderId);
        }
    }
}