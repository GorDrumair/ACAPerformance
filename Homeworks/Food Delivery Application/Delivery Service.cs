namespace DeliveryService;

public interface IDeliveryService
{
    bool AssignCourier(Guid orderId);
    string GetDeliveryStatus(Guid orderId);
}