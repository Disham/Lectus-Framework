using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Lectus.Entity.Models;
namespace Lectus.Data.Mapping
{
    public class MstEmailTypeMap : EntityTypeConfiguration<MstEmailType>
    {
        public MstEmailTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Type)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("mstEmailType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Type).HasColumnName("Type");

            // Relationships

            this.HasMany(t => t.MstBranchEmailDetails)
               .WithRequired(t => t.MstEmailType)
               .HasForeignKey(d => d.EmailTypeCode).WillCascadeOnDelete(false);
        }
    }
}
