namespace StudService1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStructureFields : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ParentsInfoes", "Phone_Id", "dbo.Phones");
            DropForeignKey("dbo.Phones", "Relation_Id", "dbo.Relations");
            DropForeignKey("dbo.StudentInfoes", "StudentPhone_Id", "dbo.Phones");
            DropIndex("dbo.ParentsInfoes", new[] { "Phone_Id" });
            DropIndex("dbo.Phones", new[] { "Relation_Id" });
            DropIndex("dbo.StudentInfoes", new[] { "StudentPhone_Id" });
            AddColumn("dbo.Adresses", "Address", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.ParentsInfoes", "FirstName", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.ParentsInfoes", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.ParentsInfoes", "WorkPlace", c => c.String(nullable: false));
            AddColumn("dbo.Phones", "PhoneNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Phones", "ParentsInfo_Id", c => c.Int());
            AddColumn("dbo.Phones", "StudentInfo_Id", c => c.Int());
            AddColumn("dbo.Relations", "Name", c => c.String(nullable: false, maxLength: 250));
            CreateIndex("dbo.Phones", "ParentsInfo_Id");
            CreateIndex("dbo.Phones", "StudentInfo_Id");
            AddForeignKey("dbo.Phones", "ParentsInfo_Id", "dbo.ParentsInfoes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Phones", "StudentInfo_Id", "dbo.StudentInfoes", "Id", cascadeDelete:true);
            DropColumn("dbo.Adresses", "IdAdress");
            DropColumn("dbo.ParentsInfoes", "MotherFirstName");
            DropColumn("dbo.ParentsInfoes", "MotherSecondName");
            DropColumn("dbo.ParentsInfoes", "FatherFirstName");
            DropColumn("dbo.ParentsInfoes", "FatherSecondName");
            DropColumn("dbo.ParentsInfoes", "MotherWorkPlace");
            DropColumn("dbo.ParentsInfoes", "FatherWorkPlace");
            DropColumn("dbo.ParentsInfoes", "Phone_Id");
            DropColumn("dbo.Phones", "IdPhone");
            DropColumn("dbo.Phones", "Relation_Id");
            DropColumn("dbo.Relations", "FirstName");
            DropColumn("dbo.Relations", "SecondName");
            DropColumn("dbo.Relations", "WorkPlace");
            DropColumn("dbo.StudentInfoes", "StudentPhone_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentInfoes", "StudentPhone_Id", c => c.Int());
            AddColumn("dbo.Relations", "WorkPlace", c => c.String(nullable: false));
            AddColumn("dbo.Relations", "SecondName", c => c.String(nullable: false));
            AddColumn("dbo.Relations", "FirstName", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.Phones", "Relation_Id", c => c.Int());
            AddColumn("dbo.Phones", "IdPhone", c => c.Int(nullable: false));
            AddColumn("dbo.ParentsInfoes", "Phone_Id", c => c.Int());
            AddColumn("dbo.ParentsInfoes", "FatherWorkPlace", c => c.String(nullable: false));
            AddColumn("dbo.ParentsInfoes", "MotherWorkPlace", c => c.String(nullable: false));
            AddColumn("dbo.ParentsInfoes", "FatherSecondName", c => c.String(nullable: false));
            AddColumn("dbo.ParentsInfoes", "FatherFirstName", c => c.String(nullable: false));
            AddColumn("dbo.ParentsInfoes", "MotherSecondName", c => c.String(nullable: false));
            AddColumn("dbo.ParentsInfoes", "MotherFirstName", c => c.String(nullable: false, maxLength: 250));
            AddColumn("dbo.Adresses", "IdAdress", c => c.String(nullable: false, maxLength: 100));
            DropForeignKey("dbo.Phones", "StudentInfo_Id", "dbo.StudentInfoes");
            DropForeignKey("dbo.Phones", "ParentsInfo_Id", "dbo.ParentsInfoes");
            DropIndex("dbo.Phones", new[] { "StudentInfo_Id" });
            DropIndex("dbo.Phones", new[] { "ParentsInfo_Id" });
            DropColumn("dbo.Relations", "Name");
            DropColumn("dbo.Phones", "StudentInfo_Id");
            DropColumn("dbo.Phones", "ParentsInfo_Id");
            DropColumn("dbo.Phones", "PhoneNumber");
            DropColumn("dbo.ParentsInfoes", "WorkPlace");
            DropColumn("dbo.ParentsInfoes", "LastName");
            DropColumn("dbo.ParentsInfoes", "FirstName");
            DropColumn("dbo.Adresses", "Address");
            CreateIndex("dbo.StudentInfoes", "StudentPhone_Id");
            CreateIndex("dbo.Phones", "Relation_Id");
            CreateIndex("dbo.ParentsInfoes", "Phone_Id");
            AddForeignKey("dbo.StudentInfoes", "StudentPhone_Id", "dbo.Phones", "Id");
            AddForeignKey("dbo.Phones", "Relation_Id", "dbo.Relations", "Id");
            AddForeignKey("dbo.ParentsInfoes", "Phone_Id", "dbo.Phones", "Id");
        }
    }
}
