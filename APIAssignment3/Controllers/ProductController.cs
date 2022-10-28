using API3Assignment.Entities;
using API3Assignment.Repository;
using Microsoft.AspNetCore.Mvc;

namespace APIAssignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController: ControllerBase
    {
        private readonly repository productRepository;
        public ProductController()
        {
            this.productRepository = new repository();
        }

        [Route("GetAllProducts")]
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            List<Product> products = productRepository.GetAllProducts();
            return StatusCode(200, products);
        }


        [HttpGet]
        [Route("Get/{id}")]
        public IActionResult Get(int id)
        {
            Product product = productRepository.GetProductById(id);
            return StatusCode(200, product);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Product product)
        {
            productRepository.AddProduct(product);
            return StatusCode(200, product);
        }


        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            productRepository.DeleteProduct(id);
            return StatusCode(200, "Product with id " + id + " Deleted");
        }

        [HttpPut]
        [Route("Edit")]
        public IActionResult Edit(Product product)
        {
            productRepository.EditProduct(product);
            return StatusCode(200, product);
        }

    }
}
