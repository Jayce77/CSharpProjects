namespace ShinRin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GrammarTerms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Term = c.String(),
                        NounFormId = c.Int(),
                        VerbFormId = c.Int(),
                        IAdjFormId = c.Int(),
                        NaAdjFomrId = c.Int(nullable: false),
                        OtherFormId = c.Int(nullable: false),
                        NaAdjForm_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IAdjForms", t => t.IAdjFormId)
                .ForeignKey("dbo.NaAdjForms", t => t.NaAdjForm_Id)
                .ForeignKey("dbo.NounForms", t => t.NounFormId)
                .ForeignKey("dbo.OtherForms", t => t.OtherFormId, cascadeDelete: true)
                .ForeignKey("dbo.VerbForms", t => t.VerbFormId)
                .Index(t => t.NounFormId)
                .Index(t => t.VerbFormId)
                .Index(t => t.IAdjFormId)
                .Index(t => t.OtherFormId)
                .Index(t => t.NaAdjForm_Id);
            
            CreateTable(
                "dbo.GrammarMeanings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Meaning = c.String(),
                        GrammarTerm_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GrammarTerms", t => t.GrammarTerm_Id)
                .Index(t => t.GrammarTerm_Id);
            
            CreateTable(
                "dbo.IAdjForms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NaAdjForms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NounForms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OtherForms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VerbForms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.GrammarTerms", "VerbFormId", "dbo.VerbForms");
            DropForeignKey("dbo.GrammarTerms", "OtherFormId", "dbo.OtherForms");
            DropForeignKey("dbo.GrammarTerms", "NounFormId", "dbo.NounForms");
            DropForeignKey("dbo.GrammarTerms", "NaAdjForm_Id", "dbo.NaAdjForms");
            DropForeignKey("dbo.GrammarTerms", "IAdjFormId", "dbo.IAdjForms");
            DropForeignKey("dbo.GrammarMeanings", "GrammarTerm_Id", "dbo.GrammarTerms");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.GrammarMeanings", new[] { "GrammarTerm_Id" });
            DropIndex("dbo.GrammarTerms", new[] { "NaAdjForm_Id" });
            DropIndex("dbo.GrammarTerms", new[] { "OtherFormId" });
            DropIndex("dbo.GrammarTerms", new[] { "IAdjFormId" });
            DropIndex("dbo.GrammarTerms", new[] { "VerbFormId" });
            DropIndex("dbo.GrammarTerms", new[] { "NounFormId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.VerbForms");
            DropTable("dbo.OtherForms");
            DropTable("dbo.NounForms");
            DropTable("dbo.NaAdjForms");
            DropTable("dbo.IAdjForms");
            DropTable("dbo.GrammarMeanings");
            DropTable("dbo.GrammarTerms");
        }
    }
}
