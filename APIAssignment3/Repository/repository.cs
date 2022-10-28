using API3Assignment.Database;
using API3Assignment.Entities;

namespace API3Assignment.Repository
{
    public class repository
    {
        private readonly DBContext context;
        public repository()
        {
            this.context = new DBContext();
        }
        public void PlaceOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public List<Order> ViewAllOrderDetails()
        {
            return context.Orders.ToList();
        }

        public Order ViewOrderDetails(int id)
        {
            Order order = context.Orders.SingleOrDefault(i => i.OrderId == id);
            return order;
        }

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product product = context.Products.SingleOrDefault(i => i.ProductId == id);
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public void EditProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            Product product = context.Products.SingleOrDefault(i => i.ProductId == id);
            return product;
        }


    }
}
