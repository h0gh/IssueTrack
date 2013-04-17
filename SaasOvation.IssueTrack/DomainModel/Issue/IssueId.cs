using System;
using SaasOvation.Common;

namespace SaasOvation.IssueTrack.DomainModel.Issue
{
    

    public class IssueId : Id<Guid>
    {
        public IssueId() : this(Guid.NewGuid()) {}
        
        public IssueId(Guid value) : base(value)
        {
        }
    }
}
