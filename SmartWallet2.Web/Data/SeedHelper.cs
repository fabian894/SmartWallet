using SmartWallet2.Web.Data.Entities;

namespace SmartWallet1.Web.Data
{
    public static class SeedHelper
    {
        public static async Task InitializeData(ApplicationDbContext context)
        {
            //1. check if customers contain data
            if (!context.Customers.Any())
            {
                //2. create sample data
                context.Customers.Add(new Customer
                {

                    FirstName = "Nola",
                    LastName = "Adeagbo",
                    BirthDate = DateTime.Now.AddYears(-20),
                    Gender = GenderEnum.Male,
                    Address = "Lagos Stresst",
                    PhoneNumber = "0 8030630067",
                    Email = "nola.ade@gmail.com",
                    Active = true
                });

                context.Customers.Add(new SmartWallet2.Web.Data.Entities.Customer
                {
                    FirstName = "Titi",
                    LastName = "Bolanle",
                    BirthDate = DateTime.Now.AddYears(-10),
                    Gender = GenderEnum.Female,
                    Address = "Lagos Street 2",
                    PhoneNumber = "09067453218",
                    Email = "titi@gmail.com",
                    Active = false
                });

                await context.SaveChangesAsync();
            }

            if (!context.Countries.Any())
            {
                //context.Countries.Add(new Country
                //{
                //    Name = "Afghanistan",
                //    IsoCode = "AFG",
                //    CallCode = "93",
                //});

                //context.Countries.Add(new Country
                //{
                //    Name = "Albania",
                //    IsoCode = "ALB",
                //    CallCode = "355",
                //});

                //context.Countries.Add(new Country
                //{
                //    Name = "ALGERIA",
                //    IsoCode = "DZA",
                //    CallCode = "93",
                //});

                context.Countries.AddRange(new List<Country>
                {
                   new Country { Name = "Afghanistan", IsoCode = "AFG", CallCode = "93" },
                    new Country { Name = "Albania", IsoCode = "ALB", CallCode = "355" },
                     new Country { Name = "Algeria", IsoCode = "DZA", CallCode = "213" },
                });
                await context.SaveChangesAsync();
            }

            if (!context.Languages.Any())
            {
                context.Languages.AddRange(new List<Language>
                {
                   new Language { Name = "English"},
                    new Language { Name = "French"},
                     new Language { Name = "Spanish"},
                });
                await context.SaveChangesAsync();
            }

        }
    }
}
