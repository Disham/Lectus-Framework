using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Lectus.Entity.Models;
namespace Lectus.Data.Mapping
{
    public class MstContactTypeMap : EntityTypeConfiguration<MstContactType>
    {
        public MstContactTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Type)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("mstContactType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Type).HasColumnName("Type");

            // Relationships

            this.HasMany(t => t.MstBranchContactDetails)
               .WithRequired(t => t.MstContactType)
               .HasForeignKey(d => d.ContactTypeCode).WillCascadeOnDelete(false);
        }
    }
}
