using SaasOvation.Common;

namespace SaasOvation.IssueTrack.DomainModel.Tenant
{
    public class TenantId : Id<string>
    {
        public TenantId(string value) : base(value)
        {
        }

        public override string Value
        {
            get { return base.Value; }
            protected set
            {
                Assert.ArgumentNotEmpty(value, "The tenant identity is required.");
                Assert.ArgumentLength(value, 36, "The tenant identity must be 36 characters or less.");

                base.Value = value;
            }
        }
    }
}
