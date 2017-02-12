namespace StudService1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesTypeFields : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Phones", new[] { "StudentInfo_Id" });
            RenameColumn(table: "dbo.StudentInfoes", name: "StudentInfo_Id", newName: "StudentPhones_Id");
            AlterColumn("dbo.Phones", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.StudentInfoes", "LastName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.StudentInfoes", "Surname", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.StudentInfoes", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.StudentInfoes", "Sex", c => c.String(nullable: false, maxLength: 250));
            CreateIndex("dbo.StudentInfoes", "StudentPhones_Id");
            DropColumn("dbo.Phones", "StudentInfo_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Phones", "StudentInfo_Id", c => c.Int());
            DropIndex("dbo.StudentInfoes", new[] { "StudentPhones_Id" });
            AlterColumn("dbo.StudentInfoes", "Sex", c => c.String(nullable: false));
            AlterColumn("dbo.StudentInfoes", "Age", c => c.String(nullable: false));
            AlterColumn("dbo.StudentInfoes", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.StudentInfoes", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Phones", "PhoneNumber", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.StudentInfoes", name: "StudentPhones_Id", newName: "StudentInfo_Id");
            CreateIndex("dbo.Phones", "StudentInfo_Id");
        }
    }
}
