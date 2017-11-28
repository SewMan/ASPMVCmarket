namespace ASPMVCmarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthTimeToCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthTime");
        }
    }
}
