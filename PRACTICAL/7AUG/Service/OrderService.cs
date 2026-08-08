using _7AUG.Data;
using _7AUG.Model;
using _7AUG.Repository;
using Microsoft.EntityFrameworkCore;

namespace _7AUG.Service
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext context;

        public OrderService(AppDbContext context)
        {
            this.context = context;
        }

        public List<Order> GetOrders()
        {
            // Load OrderItems for each Order
            // Then load Product details for each OrderItem
            return context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(i => i.Product)
                .ToList();
        }
    }
}





