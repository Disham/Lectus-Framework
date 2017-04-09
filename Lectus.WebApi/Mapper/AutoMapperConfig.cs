using AutoMapper;
using System;
using System.Linq;

namespace Lectus.WebApi.Mapper
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            // Load Core Mapper
            var coreAssembly = AppDomain.CurrentDomain.GetAssemblies().
           SingleOrDefault(assembly => assembly.GetName().Name == "Lectus.Core");
            foreach (Type type in
                coreAssembly.GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Profile))))
            {
                //(NinjectModule)Activator.CreateInstance(type);
                AutoMapper.Mapper.Initialize(cfg =>
                {
                    cfg.AddProfile((Profile)Activator.CreateInstance(type));
                });
            }
        }
    }
}