using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Lectus.Entity.Models;
namespace Lectus.Data.Mapping
{
    public class MstCompanyMap : EntityTypeConfiguration<MstCompany>
    {
        public MstCompanyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("mstCompany");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");

            // Relationships
            
            this.HasMany(t => t.MstBranches)
               .WithRequired(t => t.MstCompany)
               .HasForeignKey(d => d.CompanyCode).WillCascadeOnDelete(false);
        }
    }
}
