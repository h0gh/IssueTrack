using SaasOvation.Common;

namespace SaasOvation.IssueTrack.DomainModel.Product
{
    public class VersionId : Id<long>
    {
        public VersionId(long value)
            : base(value)
        {
        }
    }
}