using System.Collections.Generic;
using System.Linq;
using Art3xias.NailedIt.Core.Models;

namespace Art3xias.NailedIt.Core
{
    public class ServiceTypeDummyRepository
    {

        private static ShoppingCart _shoppingCart = new ShoppingCart();

        private static readonly Dictionary<string, ServiceCategory> AllCategories = new Dictionary<string, ServiceCategory>()
        {

            {"Service Category1", new ServiceCategory(1,"Service Category1") },
            {"Service Category2", new ServiceCategory(2,"Service Category2") }
        };


        public List<Service> GetAllServiceTypes() =>
            new List<Service>()
            {
                new Service(1, "Service1", new ServiceCategory(1, "Service Category1"), 300),

                new Service(2, "Service1", new ServiceCategory(1, "Service Category1"), 400),

                new Service(3, "Service1", new ServiceCategory(1, "Service Category1"), 500),

                new Service(4, "Service1", new ServiceCategory(1, "Service Category1"), 600),

                new Service(5, "Service1", new ServiceCategory(1, "Service Category1"), 700),

                new Service(6, "Service1", new ServiceCategory(1, "Service Category1"), 800),

                new Service(7, "Service1", new ServiceCategory(1, "Service Category1"), 900),

                new Service(8, "Service1", new ServiceCategory(1, "Service Category1"), 1000),

                new Service(9, "Service1", new ServiceCategory(1, "Service Category1"), 1100),

                new Service(10, "Service1", new ServiceCategory(1, "Service Category1"), 1200),

                new Service(11, "Service1", new ServiceCategory(2, "Service Category2"), 1300),

                new Service(12, "Service1", new ServiceCategory(2, "Service Category2"), 1400),

                new Service(13, "Service1", new ServiceCategory(2, "Service Category2"), 1500),

                new Service(14, "Service1", new ServiceCategory(2, "Service Category2"), 1600)
            };

        public Service GetServiceTypeById(int getInt)
        {
            return GetAllServiceTypes().Single(x => x.ServiceTypeId == getInt);
        }

        public void AddToShoppingCart(Service selectedServiceType)
        {
            var shoppingCartItem = new ShoppingCartItem()
            {
                ServiceType = selectedServiceType
            };

            _shoppingCart.CartItems.Add(shoppingCartItem);
        }

        public List<ServiceCategory> GetCategoriesWithServices()
        {
            foreach (var category in AllCategories.Values)
            {
                category.Services = GetAllServiceTypes()
                    .Where(c => c.ServiceCategoryType.ServiceCategoryName == category.ServiceCategoryName).ToList();
            }

            return AllCategories.Values.ToList();
        }
    }
}
