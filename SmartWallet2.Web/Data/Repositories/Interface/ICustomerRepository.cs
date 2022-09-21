using SmartWallet2.Web.Data.Entities;

namespace SmartWallet2.Web.Data.Repositories.Interface
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> Get(string filter);

        Task<Customer> Get(Guid id);

        Task<Guid> Add(Customer customer);

        Task Update(Customer customer);

        Task Delete(Guid id);
    }
}
