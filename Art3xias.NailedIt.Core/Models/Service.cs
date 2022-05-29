namespace Art3xias.NailedIt.Core.Models
{
    public record Service
    {
        public Service(int serviceTypeId, string serviceTypeName, ServiceCategory serviceCategoryType, decimal price)
        {
            ServiceTypeId = serviceTypeId;
            ServiceTypeName = serviceTypeName;
            ServiceCategoryType = serviceCategoryType;

        }

        public int ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public ServiceCategory ServiceCategoryType { get; set; }
        public decimal Price { get; set; }
    }
}
