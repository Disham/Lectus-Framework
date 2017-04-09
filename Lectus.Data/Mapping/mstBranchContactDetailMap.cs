using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Lectus.Entity.Models;
namespace Lectus.Data.Mapping
{
    public class MstBranchContactDetailMap : EntityTypeConfiguration<MstBranchContactDetail>
    {
        public MstBranchContactDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Number)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("mstBranchContactDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BranchCode).HasColumnName("BranchCode");
            this.Property(t => t.ContactTypeCode).HasColumnName("ContactTypeCode");
            this.Property(t => t.Number).HasColumnName("Number");
            this.Property(t => t.Show).HasColumnName("Show");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.MstBranch)
                .WithMany(t => t.MstBranchContactDetails)
                .HasForeignKey(d => d.BranchCode).WillCascadeOnDelete(false);
            this.HasRequired(t => t.MstContactType)
                .WithMany(t => t.MstBranchContactDetails)
                .HasForeignKey(d => d.ContactTypeCode).WillCascadeOnDelete(false);

        }
    }
}
