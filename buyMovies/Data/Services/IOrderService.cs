using buyMovies.Models;

namespace buyMovies.Data.Services
{
    public interface IOrderService
    {
        Task StoreOrder(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUSerIdAndRoleAsync(string userId, string userRole);
    }
}
