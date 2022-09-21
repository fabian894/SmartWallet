using Microsoft.EntityFrameworkCore;
using SmartWallet1.Web.Data;
using SmartWallet2.Web.Data.Entities;
using SmartWallet2.Web.Data.Repositories.Interface;

namespace SmartWallet2.Web.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CustomerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Add(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            await _dbContext.SaveChangesAsync();

            return customer.Id;
        }

        public async Task Delete(Guid id)
        {
            var customer = await _dbContext.Customers.FirstOrDefaultAsync(c => c.Id == id);
            _dbContext.Customers.Remove(customer!);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> Get(string filter)
        {
            var customers = await _dbContext.Customers.ToListAsync();

            return customers;
        }

        public async Task<Customer> Get(Guid id)
        {
            var customer = await _dbContext.Customers.FirstOrDefaultAsync(c=> c.Id == id);

            return customer!;
        }

        public async Task Update(Customer customer)
        {
            _dbContext.Customers.Update(customer);
            await _dbContext.SaveChangesAsync();
        }
    }
}
