using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartWallet1.Web.Data;
using SmartWallet2.Web.Data.Entities;

namespace SmartWallet1.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CustomerController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var customers = await _dbContext.Customers.ToListAsync();

            return View(customers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new Customer { BirthDate = DateTime.Now, Active = true };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer model)
        {
            if(ModelState.IsValid)
            {
                _dbContext.Customers.Add(model);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction("Index", "Customer");
            }
            

            return View(model);
        }

        

        public async Task<IActionResult> Edit(Guid id)
        {
            var model = await _dbContext.Customers.FirstOrDefaultAsync(c => c.Id == id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Customer model)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Customers.Update(model);
                await _dbContext.SaveChangesAsync();

                return RedirectToAction("Index", "Customer");
            }


            return View(model);
        }

        //[HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var model = await _dbContext.Customers.FirstOrDefaultAsync(c => c.Id == id);
            if (model != null)
            {
                //delete item
                 _dbContext.Customers.Remove(model);
                await _dbContext.SaveChangesAsync();
            }
            

                return RedirectToAction("Index", "Customer");  
        }

    }
}
  