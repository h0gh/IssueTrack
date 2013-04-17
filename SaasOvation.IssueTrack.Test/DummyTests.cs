using SaasOvation.IssueTrack.DomainModel.Issue;
using SaasOvation.IssueTrack.PortsAdapters.Persistence;
using Xunit;

namespace SaasOvation.IssueTrack.Test
{
    public class DummyTests
    {
        [Fact]
        public void Foo()
        {
            var container = CompositionRoot.Compose();
            var repo = container.Resolve<IIssueRepository>();
            Assert.IsType<InMemoryIssueRepository>(repo);
        }

        
    }
}
