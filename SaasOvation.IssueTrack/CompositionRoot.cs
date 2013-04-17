using Castle.Windsor;

namespace SaasOvation.IssueTrack
{
    public class CompositionRoot
    {
        public static IWindsorContainer Compose()
        {
            var container = new WindsorContainer();
            container.Install(new RepositoryInstaller());
            
            return container;
        }
    }
}
