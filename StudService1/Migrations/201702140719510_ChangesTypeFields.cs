namespace StudService1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesTypeFields : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.StudentInfoes", "IX_ParentsInfo_Id");
            DropIndex("dbo.StudentInfoes", new[] { "ParentsInfo_Id" });
            DropForeignKey("dbo.StudentInfoes", "FK_dbo.StudentInfoes_dbo.ParentsInfoes_ParentsInfo_Id");
            AddColumn("dbo.ParentsInfoes", "StudentInfo_Id", c => c.Int());
            AddForeignKey("dbo.ParentsInfoes", "StudentInfo_Id", "dbo.StudentInfoes", "Id");
            AlterColumn("dbo.StudentInfoes", "LastName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.StudentInfoes", "Surname", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.StudentInfoes", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.StudentInfoes", "Sex", c => c.String(nullable: false, maxLength: 250));
            CreateIndex("dbo.ParentsInfoes", "StudentInfo_Id");
            DropColumn("dbo.StudentInfoes", "ParentsInfo_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StudentInfoes", "ParentsInfo_Id", c => c.Int());
            DropIndex("dbo.ParentsInfoes", new[] { "StudentInfo_Id" });
            AlterColumn("dbo.StudentInfoes", "Sex", c => c.String(nullable: false));
            AlterColumn("dbo.StudentInfoes", "Age", c => c.String(nullable: false));
            AlterColumn("dbo.StudentInfoes", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.StudentInfoes", "LastName", c => c.String(nullable: false));
            RenameColumn(table: "dbo.ParentsInfoes", name: "StudentInfo_Id", newName: "ParentsInfo_Id");
            CreateIndex("dbo.StudentInfoes", "ParentsInfo_Id");
        }
    }
}
