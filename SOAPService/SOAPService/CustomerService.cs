namespace SOAPService
{
    public class CustomerService : ICustomerService
    {
        public string GetCustomerDetails(int customerId)
        {
            // Logic to fetch customer details based on customerId.
            return $"Customer details for ID {customerId}";
        }
    }
}