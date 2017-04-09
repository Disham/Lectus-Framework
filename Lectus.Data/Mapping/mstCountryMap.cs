using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Lectus.Entity.Models;
namespace Lectus.Data.Mapping
{
    public class MstCountryMap : EntityTypeConfiguration<MstCountry>
    {
        public MstCountryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("mstCountry");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasMany(t => t.MstStates)
                .WithRequired(t => t.MstCountry)
                .HasForeignKey(d => d.CountryCode);

            this.HasMany(t => t.MstBranchAddressDetails)
                .WithRequired(t => t.MstCountry)
                .HasForeignKey(d => d.CountryCode).WillCascadeOnDelete(false);
        }
    }
}
