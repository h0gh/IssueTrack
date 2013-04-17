using SaasOvation.Common;
using SaasOvation.IssueTrack.DomainModel.Tenant;

namespace SaasOvation.IssueTrack.DomainModel.Product
{
    class Product : Entity<ProductId,string>
    {
        public Product(TenantId tenantId, ProductId id, string name, string description, ProductOwnerId productOwnerId) : base(id)
        {
            TenantId = tenantId;
            Name = name;
            Description = description;
            ProductOwnerId = productOwnerId;
        }

        public TenantId TenantId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public ProductOwnerId ProductOwnerId { get; private set; }
    }
}