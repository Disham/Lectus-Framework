using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Lectus.Entity.Models;
namespace Lectus.Data.Mapping
{
    public class MstCityMap : EntityTypeConfiguration<MstCity>
    {
        public MstCityMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("mstCity");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StateCode).HasColumnName("StateCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.MstState)
                .WithMany(t => t.MstCities)
                .HasForeignKey(d => d.StateCode).WillCascadeOnDelete(false);

            this.HasMany(t => t.MstBranchAddressDetails)
               .WithRequired(t => t.MstCity)
               .HasForeignKey(d => d.CityCode).WillCascadeOnDelete(false);
        }
    }
}
