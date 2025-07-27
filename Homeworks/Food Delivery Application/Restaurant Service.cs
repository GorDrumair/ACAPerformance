namespace RestaurantService;

public interface IRestaurantService
{
    List<Product> GetAvailableProducts();
    Product? GetProductById(string productId);
}