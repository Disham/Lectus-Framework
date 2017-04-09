namespace Lectus.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.mstAddressType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.mstBranchAddressDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchCode = c.Int(nullable: false),
                        Show = c.Byte(),
                        Active = c.Byte(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        CountryCode = c.Int(nullable: false),
                        StateCode = c.Int(nullable: false),
                        CityCode = c.Int(nullable: false),
                        AddressTypeCode = c.Int(nullable: false),
                        Address1 = c.String(maxLength: 250),
                        Address2 = c.String(maxLength: 250),
                        Pincode = c.String(maxLength: 15),
                        IsMain = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.mstBranch", t => t.BranchCode)
                .ForeignKey("dbo.mstCity", t => t.CityCode)
                .ForeignKey("dbo.mstCountry", t => t.CountryCode)
                .ForeignKey("dbo.mstState", t => t.StateCode)
                .ForeignKey("dbo.mstAddressType", t => t.AddressTypeCode)
                .Index(t => t.BranchCode)
                .Index(t => t.CountryCode)
                .Index(t => t.StateCode)
                .Index(t => t.CityCode)
                .Index(t => t.AddressTypeCode);
            
            CreateTable(
                "dbo.mstBranch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyCode = c.Int(nullable: false),
                        Name = c.String(maxLength: 100),
                        Active = c.Byte(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.mstCompany", t => t.CompanyCode)
                .Index(t => t.CompanyCode);
            
            CreateTable(
                "dbo.mstBranchContactDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchCode = c.Int(nullable: false),
                        Active = c.Byte(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        ContactTypeCode = c.Int(nullable: false),
                        Number = c.String(maxLength: 30),
                        Show = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.mstContactType", t => t.ContactTypeCode)
                .ForeignKey("dbo.mstBranch", t => t.BranchCode)
                .Index(t => t.BranchCode)
                .Index(t => t.ContactTypeCode);
            
            CreateTable(
                "dbo.mstContactType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.mstCompany",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.mstCity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StateCode = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Active = c.Byte(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.mstState", t => t.StateCode)
                .Index(t => t.StateCode);
            
            CreateTable(
                "dbo.mstState",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryCode = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Active = c.Byte(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.mstCountry", t => t.CountryCode)
                .Index(t => t.CountryCode);
            
            CreateTable(
                "dbo.mstCountry",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Active = c.Byte(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.mstBranchEmailDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BranchCode = c.Int(),
                        Active = c.Byte(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        EmailTypeCode = c.Int(nullable: false),
                        Email = c.String(maxLength: 100),
                        Show = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.mstEmailType", t => t.EmailTypeCode)
                .Index(t => t.EmailTypeCode);
            
            CreateTable(
                "dbo.mstEmailType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.mstBranchEmailDetails", "EmailTypeCode", "dbo.mstEmailType");
            DropForeignKey("dbo.mstBranchAddressDetail", "AddressTypeCode", "dbo.mstAddressType");
            DropForeignKey("dbo.mstBranchAddressDetail", "StateCode", "dbo.mstState");
            DropForeignKey("dbo.mstBranchAddressDetail", "CountryCode", "dbo.mstCountry");
            DropForeignKey("dbo.mstBranchAddressDetail", "CityCode", "dbo.mstCity");
            DropForeignKey("dbo.mstCity", "StateCode", "dbo.mstState");
            DropForeignKey("dbo.mstState", "CountryCode", "dbo.mstCountry");
            DropForeignKey("dbo.mstBranch", "CompanyCode", "dbo.mstCompany");
            DropForeignKey("dbo.mstBranchContactDetails", "BranchCode", "dbo.mstBranch");
            DropForeignKey("dbo.mstBranchContactDetails", "ContactTypeCode", "dbo.mstContactType");
            DropForeignKey("dbo.mstBranchAddressDetail", "BranchCode", "dbo.mstBranch");
            DropIndex("dbo.mstBranchEmailDetails", new[] { "EmailTypeCode" });
            DropIndex("dbo.mstState", new[] { "CountryCode" });
            DropIndex("dbo.mstCity", new[] { "StateCode" });
            DropIndex("dbo.mstBranchContactDetails", new[] { "ContactTypeCode" });
            DropIndex("dbo.mstBranchContactDetails", new[] { "BranchCode" });
            DropIndex("dbo.mstBranch", new[] { "CompanyCode" });
            DropIndex("dbo.mstBranchAddressDetail", new[] { "AddressTypeCode" });
            DropIndex("dbo.mstBranchAddressDetail", new[] { "CityCode" });
            DropIndex("dbo.mstBranchAddressDetail", new[] { "StateCode" });
            DropIndex("dbo.mstBranchAddressDetail", new[] { "CountryCode" });
            DropIndex("dbo.mstBranchAddressDetail", new[] { "BranchCode" });
            DropTable("dbo.mstEmailType");
            DropTable("dbo.mstBranchEmailDetails");
            DropTable("dbo.mstCountry");
            DropTable("dbo.mstState");
            DropTable("dbo.mstCity");
            DropTable("dbo.mstCompany");
            DropTable("dbo.mstContactType");
            DropTable("dbo.mstBranchContactDetails");
            DropTable("dbo.mstBranch");
            DropTable("dbo.mstBranchAddressDetail");
            DropTable("dbo.mstAddressType");
        }
    }
}
