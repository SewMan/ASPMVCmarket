namespace ASPMVCmarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRequiredParamInCarModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "Slogan1", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "Slogan2", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "Slogan3", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "ImagePath1", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "ShortDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "ImagePath2", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "LongDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "ImagePath3", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "DetTransmission", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "DetWheelbase", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "DetCurbWeight", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "DetMotor", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "DetBodyStyle", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "DetProduction", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "DetLength", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "DetWidth", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "DetHeight", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "DetPrice", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "DetPrice", c => c.String());
            AlterColumn("dbo.Cars", "DetHeight", c => c.String());
            AlterColumn("dbo.Cars", "DetWidth", c => c.String());
            AlterColumn("dbo.Cars", "DetLength", c => c.String());
            AlterColumn("dbo.Cars", "DetProduction", c => c.String());
            AlterColumn("dbo.Cars", "DetBodyStyle", c => c.String());
            AlterColumn("dbo.Cars", "DetMotor", c => c.String());
            AlterColumn("dbo.Cars", "DetCurbWeight", c => c.String());
            AlterColumn("dbo.Cars", "DetWheelbase", c => c.String());
            AlterColumn("dbo.Cars", "DetTransmission", c => c.String());
            AlterColumn("dbo.Cars", "ImagePath3", c => c.String());
            AlterColumn("dbo.Cars", "LongDescription", c => c.String());
            AlterColumn("dbo.Cars", "ImagePath2", c => c.String());
            AlterColumn("dbo.Cars", "ShortDescription", c => c.String());
            AlterColumn("dbo.Cars", "ImagePath1", c => c.String());
            AlterColumn("dbo.Cars", "Slogan3", c => c.String());
            AlterColumn("dbo.Cars", "Slogan2", c => c.String());
            AlterColumn("dbo.Cars", "Slogan1", c => c.String());
            AlterColumn("dbo.Cars", "Name", c => c.String());
        }
    }
}
