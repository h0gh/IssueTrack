using System;
using SaasOvation.Common;
using SaasOvation.IssueTrack.DomainModel.Product;
using SaasOvation.IssueTrack.DomainModel.Tenant;

namespace SaasOvation.IssueTrack.DomainModel.Issue
{
    internal class IssueAssociatedWithNewBacklogItem : IDomainEvent
    {
        public TenantId TenantId { get; set; }
        public ProductId ProductId { get; set; }
        public IssueId IssueId { get; set; }

        public int EventVersion { get; private set; }
        public DateTime OccurredOn { get; private set; }


        public IssueAssociatedWithNewBacklogItem(TenantId tenantId, ProductId productId, IssueId issueId)
        {
            TenantId = tenantId;
            ProductId = productId;
            IssueId = issueId;
            OccurredOn = DateTime.Now;
        }
    }
}