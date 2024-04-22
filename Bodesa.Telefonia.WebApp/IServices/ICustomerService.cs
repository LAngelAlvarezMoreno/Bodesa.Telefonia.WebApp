using Bodesa.Telefonia.WebApp.Entities;

namespace Bodesa.Telefonia.WebApp.IServices
{
    public interface ICustomerService
    {

        public Task<IEnumerable<Entities.cnf_CustomerData>> GetAllCustomersAsync();

        public Task<Entities.cnf_CustomerData> GetCustomerByPhoneNumber(string phoneNumber);

        public Task<string> SaveCustomer(cnf_CustomerData customer);
        public Task<string> AddCustomer(cnf_CustomerData customer);
        public Task<string> DeleteCustomer(string id);
    }
}
