using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectus.Core
{
    public static class CoreDependancyResolver
    {
        public static T Resolve<T>()
        {
            var kernel = new StandardKernel(new CoreDependancyInjectionModule());
            return kernel.Get<T>();
        }
    }
}
