namespace StudService1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypePhoneNumberField : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Phones", "PhoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Phones", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
