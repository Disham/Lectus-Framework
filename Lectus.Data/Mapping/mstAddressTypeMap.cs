using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Lectus.Entity.Models;
namespace Lectus.Data.Mapping
{
    public class MstAddressTypeMap : EntityTypeConfiguration<MstAddressType>
    {
        public MstAddressTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Type)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("mstAddressType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Type).HasColumnName("Type");

            // Relationships
            this.HasMany(t => t.MstBranchAddressDetails)
                .WithRequired(t => t.MstAddressType)
                .HasForeignKey(d => d.AddressTypeCode)
                .WillCascadeOnDelete(false);
        }
    }
}
