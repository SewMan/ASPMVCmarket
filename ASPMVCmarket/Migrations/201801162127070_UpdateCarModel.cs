namespace ASPMVCmarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCarModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "ImagePath1", c => c.String());
            AddColumn("dbo.Cars", "ImagePath2", c => c.String());
            AddColumn("dbo.Cars", "LongDescription", c => c.String());
            AddColumn("dbo.Cars", "ImagePath3", c => c.String());
            AddColumn("dbo.Cars", "DetTransmission", c => c.String());
            AddColumn("dbo.Cars", "DetWheelbase", c => c.String());
            AddColumn("dbo.Cars", "DetCurbWeight", c => c.String());
            AddColumn("dbo.Cars", "DetMotor", c => c.String());
            AddColumn("dbo.Cars", "DetBodyStyle", c => c.String());
            AddColumn("dbo.Cars", "DetProduction", c => c.String());
            AddColumn("dbo.Cars", "DetLength", c => c.String());
            AddColumn("dbo.Cars", "DetWidth", c => c.String());
            AddColumn("dbo.Cars", "DetHeight", c => c.String());
            AddColumn("dbo.Cars", "DetPrice", c => c.String());
            DropColumn("dbo.Cars", "ImagePath");
            DropColumn("dbo.Cars", "ReleaseData");
            DropColumn("dbo.Cars", "AmountInStock");
            DropColumn("dbo.Cars", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "Description", c => c.String());
            AddColumn("dbo.Cars", "AmountInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "ReleaseData", c => c.DateTime(nullable: false));
            AddColumn("dbo.Cars", "ImagePath", c => c.String());
            DropColumn("dbo.Cars", "DetPrice");
            DropColumn("dbo.Cars", "DetHeight");
            DropColumn("dbo.Cars", "DetWidth");
            DropColumn("dbo.Cars", "DetLength");
            DropColumn("dbo.Cars", "DetProduction");
            DropColumn("dbo.Cars", "DetBodyStyle");
            DropColumn("dbo.Cars", "DetMotor");
            DropColumn("dbo.Cars", "DetCurbWeight");
            DropColumn("dbo.Cars", "DetWheelbase");
            DropColumn("dbo.Cars", "DetTransmission");
            DropColumn("dbo.Cars", "ImagePath3");
            DropColumn("dbo.Cars", "LongDescription");
            DropColumn("dbo.Cars", "ImagePath2");
            DropColumn("dbo.Cars", "ImagePath1");
        }
    }
}
