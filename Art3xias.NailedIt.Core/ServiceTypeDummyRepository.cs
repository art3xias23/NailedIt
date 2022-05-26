using System.Collections.Generic;
using Art3xias.NailedIt.Core.Models;

namespace Art3xias.NailedIt.Core
{
    public class ServiceTypeDummyRepository
    {
        public List<ServiceType> GetAllServiceTypes() =>
            new List<ServiceType>()
            {
                new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1")), new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1")),  new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1")),  new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1")),  new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1")),  new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1")),  new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1")),  new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1")),  new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1")),  new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1")),  new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1")),  new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1")),  new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1")),  new ServiceType(1, "Service1", new ServiceCategoryType(1, "Service Category1"))            };
    }
}
