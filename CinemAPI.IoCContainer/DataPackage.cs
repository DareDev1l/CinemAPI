using CinemAPI.Data;
using CinemAPI.Data.Implementation;
using SimpleInjector;
using SimpleInjector.Packaging;

namespace CinemAPI.IoCContainer
{
    public class DataPackage : IPackage
    {
        public void RegisterServices(Container container)
        {
            container.Register<ICinemaRepository, CinemaRepository>();
        }
    }
}