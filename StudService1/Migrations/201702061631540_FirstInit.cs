namespace StudService1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdAdress = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Speciality = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ParentsInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MotherFirstName = c.String(nullable: false, maxLength: 250),
                        MotherSecondName = c.String(nullable: false),
                        FatherFirstName = c.String(nullable: false),
                        FatherSecondName = c.String(nullable: false),
                        MotherWorkPlace = c.String(nullable: false),
                        FatherWorkPlace = c.String(nullable: false),
                        Phone_Id = c.Int(),
                        Relation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Phones", t => t.Phone_Id)
                .ForeignKey("dbo.Relations", t => t.Relation_Id)
                .Index(t => t.Phone_Id)
                .Index(t => t.Relation_Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPhone = c.Int(nullable: false),
                        Relation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Relations", t => t.Relation_Id)
                .Index(t => t.Relation_Id);
            
            CreateTable(
                "dbo.Relations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 250),
                        SecondName = c.String(nullable: false),
                        WorkPlace = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 250),
                        LastName = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Age = c.String(nullable: false),
                        Sex = c.String(nullable: false),
                        NumberRecordBook = c.Int(nullable: false),
                        Birthdate = c.DateTime(nullable: false),
                        Adress_Id = c.Int(),
                        Group_Id = c.Int(),
                        ParentsInfo_Id = c.Int(),
                        StudentPhone_Id = c.Int(),
                        StudentProgress_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresses", t => t.Adress_Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .ForeignKey("dbo.ParentsInfoes", t => t.ParentsInfo_Id)
                .ForeignKey("dbo.Phones", t => t.StudentPhone_Id)
                .ForeignKey("dbo.StudentProgresses", t => t.StudentProgress_Id)
                .Index(t => t.Adress_Id)
                .Index(t => t.Group_Id)
                .Index(t => t.ParentsInfo_Id)
                .Index(t => t.StudentPhone_Id)
                .Index(t => t.StudentProgress_Id);
            
            CreateTable(
                "dbo.StudentProgresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Progress = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentInfoes", "StudentProgress_Id", "dbo.StudentProgresses");
            DropForeignKey("dbo.StudentInfoes", "StudentPhone_Id", "dbo.Phones");
            DropForeignKey("dbo.StudentInfoes", "ParentsInfo_Id", "dbo.ParentsInfoes");
            DropForeignKey("dbo.StudentInfoes", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.StudentInfoes", "Adress_Id", "dbo.Adresses");
            DropForeignKey("dbo.ParentsInfoes", "Relation_Id", "dbo.Relations");
            DropForeignKey("dbo.Phones", "Relation_Id", "dbo.Relations");
            DropForeignKey("dbo.ParentsInfoes", "Phone_Id", "dbo.Phones");
            DropIndex("dbo.StudentInfoes", new[] { "StudentProgress_Id" });
            DropIndex("dbo.StudentInfoes", new[] { "StudentPhone_Id" });
            DropIndex("dbo.StudentInfoes", new[] { "ParentsInfo_Id" });
            DropIndex("dbo.StudentInfoes", new[] { "Group_Id" });
            DropIndex("dbo.StudentInfoes", new[] { "Adress_Id" });
            DropIndex("dbo.Phones", new[] { "Relation_Id" });
            DropIndex("dbo.ParentsInfoes", new[] { "Relation_Id" });
            DropIndex("dbo.ParentsInfoes", new[] { "Phone_Id" });
            DropTable("dbo.StudentProgresses");
            DropTable("dbo.StudentInfoes");
            DropTable("dbo.Relations");
            DropTable("dbo.Phones");
            DropTable("dbo.ParentsInfoes");
            DropTable("dbo.Groups");
            DropTable("dbo.Adresses");
        }
    }
}
