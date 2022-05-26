using System.Collections.Generic;
using System.Linq;
using Art3xias.NailedIt.Core.Models;

namespace Art3xias.NailedIt.Core
{
    public class ServiceTypeDummyRepository
    {

        private static ShoppingCart _shoppingCart = new ShoppingCart();

        private static readonly Dictionary<string, ServiceCategoryType> AllCategories = new Dictionary<string, ServiceCategoryType>()
        {

            {"Service Category1", new ServiceCategoryType(1,"Service Category1") },
            {"Service Category2", new ServiceCategoryType(2,"Service Category2") }
        };


        public List<ServiceType> GetAllServiceTypes() =>
            new List<ServiceType>()
            {
                new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1"), 300),

                new ServiceType(2, "Service1", new ServiceCategoryType(1, "Service Category1"), 400),

                new ServiceType(3, "Service1", new ServiceCategoryType(1, "Service Category1"), 500),

                new ServiceType(4, "Service1", new ServiceCategoryType(1, "Service Category1"), 600),

                new ServiceType(5, "Service1", new ServiceCategoryType(1, "Service Category1"), 700),

                new ServiceType(6, "Service1", new ServiceCategoryType(1, "Service Category1"), 800),

                new ServiceType(7, "Service1", new ServiceCategoryType(1, "Service Category1"), 900),

                new ServiceType(8, "Service1", new ServiceCategoryType(1, "Service Category1"), 1000),

                new ServiceType(9, "Service1", new ServiceCategoryType(1, "Service Category1"), 1100),

                new ServiceType(10, "Service1", new ServiceCategoryType(1, "Service Category1"), 1200),

                new ServiceType(11, "Service1", new ServiceCategoryType(1, "Service Category2"), 1300),

                new ServiceType(12, "Service1", new ServiceCategoryType(1, "Service Category2"), 1400),

                new ServiceType(13, "Service1", new ServiceCategoryType(1, "Service Category2"), 1500),

                new ServiceType(14, "Service1", new ServiceCategoryType(1, "Service Category2"), 1600)
            };

        public ServiceType GetServiceTypeById(int getInt)
        {
            return GetAllServiceTypes().Single(x => x.ServiceTypeId == getInt);
        }

        public void AddToShoppingCart(ServiceType selectedServiceType)
        {
            var shoppingCartItem = new ShoppingCartItem()
            {
                ServiceType = selectedServiceType
            };

            _shoppingCart.CartItems.Add(shoppingCartItem);
        }

        public List<ServiceCategoryType> GetCategoriesWithServices()
        {
            foreach (var category in AllCategories.Values)
            {
                category.ServiceTypes = GetAllServiceTypes()
                    .Where(c => c.ServiceCategoryType.ServiceCategoryTypeName == category.ServiceCategoryTypeName).ToList();
            }

            return AllCategories.Values.ToList();
        }
    }
}
