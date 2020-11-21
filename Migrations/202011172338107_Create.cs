namespace MGRescue_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adoptions",
                c => new
                    {
                        AnimalID = c.Guid(nullable: false),
                        AnimalName = c.String(nullable: false, maxLength: 128),
                        SpeciesIso3 = c.String(maxLength: 3),
                        BreedCode = c.String(maxLength: 3),
                        ReferenceNumber = c.String(),
                        Sex = c.String(),
                        Primary_Colour = c.String(),
                        Secondary_Colour = c.String(),
                        Tertiary_Colour = c.String(),
                        Coat_Type = c.String(),
                        Years = c.Int(),
                        Months = c.Int(),
                        Description = c.String(),
                        Particular_Markings = c.String(),
                        ImagePath = c.String(),
                        Animal_Comments = c.String(),
                        Operations = c.String(),
                        Health_Problems = c.String(),
                        Medications = c.String(),
                        Bloodtested = c.String(),
                        Blood_test_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Animals_Vet = c.String(),
                        Vet_Address = c.String(),
                        Medical_Comments = c.String(),
                        Microchipped = c.String(),
                        ChipNumber = c.String(),
                        Vaccinated = c.String(),
                        Vac_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Vac_Type = c.String(),
                        Neutered = c.String(),
                        Neutered_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Flead = c.String(),
                        Flead_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Wormed = c.String(),
                        Wormed_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Special_Diet_Type = c.String(),
                        Diet_Product = c.String(),
                        Amount = c.String(),
                        Diet_Frequency = c.String(),
                        Diet_Frequency_Type = c.String(),
                        Diet_Start = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Diet_End = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Diet_Comments = c.String(),
                        Vac_Treatment = c.String(),
                        Treatment_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Next_Due = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Other_Treatment = c.String(),
                        Treatment_Name = c.String(),
                        Start_Treatment = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        End_Treatment = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Dosage = c.String(),
                        Dose_Frequency = c.String(),
                        Dose_Frequecy_Type = c.String(),
                        Specific_Info = c.String(),
                        Person_Type = c.String(),
                        Persons_FirstName = c.String(),
                        Persons_Surname = c.String(),
                        Persons_Address = c.String(),
                        Persons_Phone_Number = c.String(),
                        Reason_for_entry = c.String(),
                        Entry_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Other_Details = c.String(),
                        Good_With_Dogs = c.String(),
                        Experience_with_Dogs = c.String(),
                        Good_With_Cats = c.String(),
                        Experience_with_Cats = c.String(),
                        Good_With_Smallies = c.String(),
                        Experience_with_Smallies = c.String(),
                        Good_With_Kids = c.String(),
                        Experience_with_Kids = c.String(),
                        Child_ages = c.String(),
                        Good_with_Strangers = c.String(),
                        Experience_with_Strangers = c.String(),
                        Biting = c.String(),
                        Bite_Details = c.String(),
                        Possessive = c.String(),
                        Possessive_Details = c.String(),
                        Fear = c.String(),
                        FearDetails = c.String(),
                        Behaviour_at_Vets = c.String(),
                        Animal_Demeanor = c.String(),
                        Behaviour_at_Groomers = c.String(),
                        Left_Alone = c.String(),
                        Good_with_Food = c.String(),
                        Good_being_Handled = c.String(),
                        Commands = c.String(),
                        Commands_Comments = c.String(),
                        Behavioural_Comments = c.String(),
                        Movement_Type = c.String(),
                        Movement_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Reserved_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Reserve_Length = c.String(),
                        Reserve_Length_Type = c.String(),
                    })
                .PrimaryKey(t => t.AnimalID)
                .ForeignKey("dbo.Breeds", t => t.BreedCode)
                .ForeignKey("dbo.Species", t => t.SpeciesIso3)
                .Index(t => t.SpeciesIso3)
                .Index(t => t.BreedCode);
            
            CreateTable(
                "dbo.Breeds",
                c => new
                    {
                        BreedCode = c.String(nullable: false, maxLength: 3),
                        Iso3 = c.String(nullable: false, maxLength: 3),
                        BreedNameEnglish = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.BreedCode);
            
            CreateTable(
                "dbo.Species",
                c => new
                    {
                        Iso3 = c.String(nullable: false, maxLength: 3),
                        SpeciesNameEnglish = c.String(),
                    })
                .PrimaryKey(t => t.Iso3);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Description = c.String(),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(),
                        ThemeColor = c.String(),
                        IsFullDay = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MessageType = c.String(),
                        Message = c.String(maxLength: 500),
                        To = c.String(maxLength: 255),
                        From = c.String(),
                        Email = c.String(maxLength: 255),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Description = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
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
                        Address = c.String(),
                        City = c.String(),
                        County = c.String(),
                        PostCode = c.String(),
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
            DropForeignKey("dbo.Adoptions", "SpeciesIso3", "dbo.Species");
            DropForeignKey("dbo.Adoptions", "BreedCode", "dbo.Breeds");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Adoptions", new[] { "BreedCode" });
            DropIndex("dbo.Adoptions", new[] { "SpeciesIso3" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.Events");
            DropTable("dbo.Species");
            DropTable("dbo.Breeds");
            DropTable("dbo.Adoptions");
        }
    }
}
