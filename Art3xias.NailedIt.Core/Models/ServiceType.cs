﻿namespace Art3xias.NailedIt.Core.Models
{
    public record ServiceType
    {
        public ServiceType(int serviceTypeId, string serviceTypeName, ServiceCategoryType serviceCategoryTypeName, decimal price)
        {
            ServiceTypeId = serviceTypeId;
            ServiceTypeName = serviceTypeName;
            ServiceCategoryTypeName = serviceCategoryTypeName;

        }

        public int ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public ServiceCategoryType ServiceCategoryTypeName { get; set; }
        public decimal Price { get; set; }
    }
}
