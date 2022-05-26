using System.Collections.Generic;

namespace Art3xias.NailedIt.Core.Models
{
    public record ServiceCategoryType
    {
        public ServiceCategoryType(int serviceCategoryTypeId, string serviceCategoryTypeName)
        {
            ServiceCategoryTypeName = serviceCategoryTypeName;
            ServiceCategoryTypeId = serviceCategoryTypeId;
        }

        public int ServiceCategoryTypeId { get; set; }
        public string ServiceCategoryTypeName { get; set; }
        public List<ServiceType> ServiceTypes { get; set; }
    }
}
