using Lectus.Core.EntityFramework;
using Lectus.Domain.Models;
using Lectus.Entity.Models;
using Lectus.Repository.Repositories;
using Lectus.Repository.UnitOfWork;
using Ninject.Modules;

namespace Lectus.Core
{
    public class CoreDependancyInjectionModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<DbContext>().To<LectusRetailContext>().InSingletonScope();

            Bind<IUnitOfWork>().To<EFUOW>();

            Bind<IRepository<MstCountry>>().To<MasterRepository<MstCountry>>().InSingletonScope();
        }
    }
}
