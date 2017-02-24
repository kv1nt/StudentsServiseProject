namespace StudService1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_FatherInfo_fields_AddMaxLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParentsInfoes", "MotherLastName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.ParentsInfoes", "MotherWorkPlace", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.ParentsInfoes", "FatherFirstName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.ParentsInfoes", "FatherLastName", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.ParentsInfoes", "FatherWorkPlace", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParentsInfoes", "FatherWorkPlace", c => c.String(nullable: false));
            AlterColumn("dbo.ParentsInfoes", "FatherLastName", c => c.String(nullable: false));
            AlterColumn("dbo.ParentsInfoes", "FatherFirstName", c => c.String(nullable: false));
            AlterColumn("dbo.ParentsInfoes", "MotherWorkPlace", c => c.String(nullable: false));
            AlterColumn("dbo.ParentsInfoes", "MotherLastName", c => c.String(nullable: false));
        }
    }
}
