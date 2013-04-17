using SaasOvation.Common;

namespace SaasOvation.IssueTrack.DomainModel.Product
{
    public class ProductOwnerId : Id<string>
    {
        public ProductOwnerId(string value) : base(value)
        {
        }
    }
}