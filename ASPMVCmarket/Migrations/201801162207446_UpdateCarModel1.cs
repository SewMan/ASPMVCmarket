namespace ASPMVCmarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCarModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Slogan3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Slogan3");
        }
    }
}
