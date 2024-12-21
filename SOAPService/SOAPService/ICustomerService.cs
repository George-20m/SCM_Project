using System.ServiceModel;

[ServiceContract]
public interface ICustomerService
{
    [OperationContract]
    string GetCustomerDetails(int customerId);
}

public class CustomerService : ICustomerService
{
    public string GetCustomerDetails(int customerId)
    {
        // Implementation for retrieving customer details
        return $"Customer details for ID: {customerId}";
    }
}
