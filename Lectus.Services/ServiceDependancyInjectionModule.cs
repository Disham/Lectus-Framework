using Lectus.Domain.Models;
using Lectus.Services.MasterServices;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectus.Services
{
    public class ServiceDependancyInjectionModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<DbContext>().To<LectusRetailContext>().InSingletonScope();
            Bind<IMasterService<ICountry>>().To<CountryService>().InSingletonScope();
        }
    }
}
