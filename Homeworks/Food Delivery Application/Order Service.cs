namespace OrderService;

public interface IOrderService
{
    Guid PlaceOrder(List<string> productIds);
    decimal CalculateTotal(List<string> productIds);
    bool ValidateItems(List<string> productIds);
}