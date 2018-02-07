namespace ASPMVCmarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSlogansImagePathShortDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Slogan1", c => c.String());
            AddColumn("dbo.Cars", "Slogan2", c => c.String());
            AddColumn("dbo.Cars", "ImagePath", c => c.String());
            AddColumn("dbo.Cars", "ShortDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "ShortDescription");
            DropColumn("dbo.Cars", "ImagePath");
            DropColumn("dbo.Cars", "Slogan2");
            DropColumn("dbo.Cars", "Slogan1");
        }
    }
}
