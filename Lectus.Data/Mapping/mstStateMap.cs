using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Lectus.Entity.Models;
namespace Lectus.Data.Mapping
{
    public class MstStateMap : EntityTypeConfiguration<MstState>
    {
        public MstStateMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("mstState");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CountryCode).HasColumnName("CountryCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.MstCountry)
                .WithMany(t => t.MstStates)
                .HasForeignKey(d => d.CountryCode).WillCascadeOnDelete(false);

            this.HasMany(t => t.MstCities)
                .WithRequired(t => t.MstState)
                .HasForeignKey(d => d.StateCode).WillCascadeOnDelete(false);

            this.HasMany(t => t.MstBranchAddressDetails)
                .WithRequired(t => t.MstState)
                .HasForeignKey(d => d.StateCode).WillCascadeOnDelete(false);

        }
    }
}
