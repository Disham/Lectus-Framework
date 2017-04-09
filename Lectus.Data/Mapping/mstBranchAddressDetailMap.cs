using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Lectus.Entity.Models;
namespace Lectus.Data.Mapping
{
    public class MstBranchAddressDetailMap : EntityTypeConfiguration<MstBranchAddressDetail>
    {
        public MstBranchAddressDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Address1)
                .HasMaxLength(250);

            this.Property(t => t.Address2)
                .HasMaxLength(250);

            this.Property(t => t.Pincode)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("mstBranchAddressDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BranchCode).HasColumnName("BranchCode");
            this.Property(t => t.AddressTypeCode).HasColumnName("AddressTypeCode");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.Pincode).HasColumnName("Pincode");
            this.Property(t => t.IsMain).HasColumnName("IsMain");
            this.Property(t => t.Show).HasColumnName("Show");
            this.Property(t => t.Active).HasColumnName("Active");


            this.Property(t => t.CountryCode).HasColumnName("CountryCode");
            this.Property(t => t.StateCode).HasColumnName("StateCode");
            this.Property(t => t.CityCode).HasColumnName("CityCode");

            // Relationships
            this.HasRequired(t => t.MstAddressType)
                .WithMany(t => t.MstBranchAddressDetails)
                .HasForeignKey(d => d.AddressTypeCode).WillCascadeOnDelete(false);

            this.HasRequired(t => t.MstBranch)
                .WithMany(t => t.MstBranchAddressDetails)
                .HasForeignKey(d => d.BranchCode).WillCascadeOnDelete(false);

            this.HasRequired(t => t.MstCity)
                .WithMany(t => t.MstBranchAddressDetails)
                .HasForeignKey(d => d.CityCode).WillCascadeOnDelete(false);

            this.HasRequired(t => t.MstCountry)
                .WithMany(t => t.MstBranchAddressDetails)
                .HasForeignKey(d => d.CountryCode).WillCascadeOnDelete(false);

            this.HasRequired(t => t.MstState)
                .WithMany(t => t.MstBranchAddressDetails)
                .HasForeignKey(d => d.StateCode);

        }
    }
}
