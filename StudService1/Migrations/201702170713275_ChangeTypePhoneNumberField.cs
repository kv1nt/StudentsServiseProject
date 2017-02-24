namespace StudService1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class ChangeTypePhoneNumberField : DbMigration
    {
        public override void Up()
        {
            Sql(@"ALTER TABLE dbo.Phones
                DROP CONSTRAINT IF EXISTS DF__Phones__PhoneNum__3C69FB99
                GO");
            //DropIndex("dbo.Phones", "DF__Phones__PhoneNum__3C69FB99");
            AlterColumn("dbo.Phones", "PhoneNumber", c => c.String(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Phones", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
