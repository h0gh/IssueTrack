using SaasOvation.Common;

namespace SaasOvation.IssueTrack.DomainModel.Product
{
    public class ProductId : Id<string>
    {
        public ProductId(string value) : base(value)
        {
        }
    }
}
