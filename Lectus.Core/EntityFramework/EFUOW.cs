using Lectus.Data.Mapping;
using Lectus.Domain;
using Lectus.Repository.UnitOfWork;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;

namespace Lectus.Core.EntityFramework
{
    public class EFUOW : DbContext, IUnitOfWork
    {
        static EFUOW()
        {
            Database.SetInitializer<EFUOW>(null);
        }

        public EFUOW()
            : base("Name=LectusRetailContext")
        {
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditable
                    && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IAuditable entity = entry.Entity as IAuditable;
                if (entity != null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == System.Data.Entity.EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //foreach (Type type in
            //Assembly.GetAssembly(typeof(EntityTypeConfiguration<>)).GetTypes()
            //.Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(EntityTypeConfiguration<>))))
            //{
            //    // modelBuilder.Configurations.Add((EntityTypeConfiguration<BaseEntity>)Activator.CreateInstance(type));
            //    //kernel.Bind<IRepository<type>>().To<Repository<>>();
            //}

            modelBuilder.Configurations.Add(new MstAddressTypeMap());
            modelBuilder.Configurations.Add(new MstBranchMap());
            modelBuilder.Configurations.Add(new MstBranchAddressDetailMap());
            modelBuilder.Configurations.Add(new MstBranchContactDetailMap());
            modelBuilder.Configurations.Add(new MstBranchEmailDetailMap());
            modelBuilder.Configurations.Add(new MstCityMap());
            modelBuilder.Configurations.Add(new MstCompanyMap());
            modelBuilder.Configurations.Add(new MstContactTypeMap());
            modelBuilder.Configurations.Add(new MstCountryMap());
            modelBuilder.Configurations.Add(new MstEmailTypeMap());
            modelBuilder.Configurations.Add(new MstStateMap());
        }

        /// <summary>
        /// Saves all pending changes
        /// </summary>
        /// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
        public int Committ()
        {
            // Save changes with the default options
            return SaveChanges();
        }

        /// <summary>
        /// Rollback the current object
        /// </summary>
        public void Rollback()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
