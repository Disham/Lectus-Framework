using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Lectus.Entity.Models;
namespace Lectus.Data.Mapping
{
    public class MstBranchEmailDetailMap : EntityTypeConfiguration<MstBranchEmailDetail>
    {
        public MstBranchEmailDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Email)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("mstBranchEmailDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BranchCode).HasColumnName("BranchCode");
            this.Property(t => t.EmailTypeCode).HasColumnName("EmailTypeCode");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Show).HasColumnName("Show");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.MstEmailType)
                .WithMany(t => t.MstBranchEmailDetails)
                .HasForeignKey(d => d.EmailTypeCode).WillCascadeOnDelete(false);

        }
    }
}
