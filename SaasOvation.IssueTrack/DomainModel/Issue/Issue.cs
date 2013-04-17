using System;
using SaasOvation.Common;
using SaasOvation.IssueTrack.DomainModel.Product;
using SaasOvation.IssueTrack.DomainModel.Tenant;
using Version = SaasOvation.IssueTrack.DomainModel.Product.Version;

namespace SaasOvation.IssueTrack.DomainModel.Issue
{
    class Issue : Entity<IssueId,Guid>
    {
        public Issue(TenantId tenantId, IssueId id, Product.Product product, string title, IssueType type,
                     Severity severity, string description)
            : this(tenantId, id, product, null, title, type, severity, description)
        {
        }

        public Issue(TenantId tenantId, IssueId id, Product.Product product, Version version, string title, IssueType type, Severity severity, string description) : base(id)
        {
            TenantId = tenantId;
            Title = title;
            Type = type;
            Severity = severity;
            Description = description;
            ProductId = product.Id;
            VersionId = version.Id;
            Status = IssueStatus.Open;
        }

        public void AssociateWithBacklogItem()
        {
            DomainEventManager.Raise(
                new IssueAssociatedWithNewBacklogItem(TenantId, ProductId, Id));
        }

        protected VersionId VersionId { get; set; }
        protected TenantId TenantId { get; private set; }
        protected ProductId ProductId { get; private set; }
        protected IssueStatus Status { get; private set; }

        public string Title { get; private set; }
        public string Description { get; private set; }


        public Severity Severity { get; private set; }

        public IssueType Type { get; private set; }

        //comments
        //status (and changes)
        //creator
        //assignee

    }

    internal enum IssueType
    {
        Defect,
        Feature,

    }

    internal enum Severity
    {
        Blocker = 1,
        Critical = 2,
        Major = 3,
        Minor = 4
    }

    internal enum IssueStatus
    {
        Open = 1,
        InProgress = 2,
        Fixed = 3,
        Rejected = 4,
        Duplicate = 5,
    }
   
}
