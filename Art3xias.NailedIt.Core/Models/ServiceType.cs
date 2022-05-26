namespace Art3xias.NailedIt.Core.Models
{
    public record ServiceType
    {
        public ServiceType(int serviceTypeId, string serviceTypeName, ServiceCategoryType serviceCategoryType, decimal price)
        {
            ServiceTypeId = serviceTypeId;
            ServiceTypeName = serviceTypeName;
            ServiceCategoryType = serviceCategoryType;

        }

        public int ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public ServiceCategoryType ServiceCategoryType { get; set; }
        public decimal Price { get; set; }
    }
}
