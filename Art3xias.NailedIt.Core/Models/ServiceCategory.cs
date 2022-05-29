using System.Collections.Generic;

namespace Art3xias.NailedIt.Core.Models
{
    public record ServiceCategory
    {
        public ServiceCategory(int serviceCategoryTypeId, string serviceCategoryTypeName)
        {
            ServiceCategoryName = serviceCategoryTypeName;
            ServiceCategoryTypeId = serviceCategoryTypeId;
        }

        public int ServiceCategoryTypeId { get; set; }
        public string ServiceCategoryName { get; set; }
        public List<Service> Services { get; set; }
    }
}
