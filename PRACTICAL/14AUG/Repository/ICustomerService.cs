using _14AUG.Model;

namespace _14AUG.Repository
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();

        Customer GetCustomerById(int id);

        Customer AddCustomer(Customer customer);

    }
}
