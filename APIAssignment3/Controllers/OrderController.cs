using API3Assignment.Entities;
using API3Assignment.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API3Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController:ControllerBase
    {
        private readonly repository orderRepository;
        public OrderController()
        {
            this.orderRepository = new repository();
        }

        [Route("GetAllOrders")]
        [HttpGet]
        public IActionResult ViewAllOrderDetails()
        {
            List<Order> orders = orderRepository.ViewAllOrderDetails();
            return StatusCode(200, orders);
        }


        [HttpGet]
        [Route("Get/{id}")]
        public IActionResult ViewOrderDetails(int id)
        {
            Order order = orderRepository.ViewOrderDetails(id);
            return StatusCode(200, order);
        }


        [HttpPost]
        [Route("Add")]
        public IActionResult PlaceOrder(Order order)
        {
            orderRepository.PlaceOrder(order);
            return StatusCode(200, order);
        }

    }
}
