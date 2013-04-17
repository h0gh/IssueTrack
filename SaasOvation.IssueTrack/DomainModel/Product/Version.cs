using SaasOvation.Common;
using SaasOvation.IssueTrack.DomainModel.Tenant;

namespace SaasOvation.IssueTrack.DomainModel.Product
{
    public class Version : Entity<VersionId, long>
    {
        public TenantId TenantId { get; private set; }
        public ProductId ProductId { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Version(VersionId id, TenantId tenantId, ProductId productId, string name, string description)
            : base(id)
        {
            TenantId = tenantId;
            ProductId = productId;
            Name = name;
            Description = description;
        }
    }
}