using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Lectus.Entity.Models;
namespace Lectus.Data.Mapping
{
    public class MstBranchMap : EntityTypeConfiguration<MstBranch>
    {
        public MstBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("mstBranch");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.MstCompany)
                .WithMany(t => t.MstBranches)
                .HasForeignKey(d => d.CompanyCode).WillCascadeOnDelete(false);

            this.HasMany(t => t.MstBranchAddressDetails)
                .WithRequired(t => t.MstBranch)
                .HasForeignKey(d => d.BranchCode).WillCascadeOnDelete(false);

            this.HasMany(t => t.MstBranchContactDetails)
                .WithRequired(t => t.MstBranch)
                .HasForeignKey(d => d.BranchCode).WillCascadeOnDelete(false);
        }
    }
}
