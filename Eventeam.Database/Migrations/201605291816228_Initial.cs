using System.IO;
using Eventeam.Database.Helpers;

namespace Eventeam.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            Sql(ResourceHelper.ReadEmbedded("Eventeam.Database.Migrations.201605291816228_Initial.sql"));
        }

        public override void Down()
        {
            DropForeignKey("Portfolio.Portfolio", "FormatID", "Portfolio.Format");
            DropForeignKey("dbo.Platform", "CityID", "dbo.City");
            DropForeignKey("Restaurant.Restaurant", "PlatformID", "dbo.Platform");
            DropForeignKey("Restaurant.Restaurant", "TypeID", "Restaurant.RestaurantType");
            DropForeignKey("Restaurant.Restaurant", "KitchenID", "Restaurant.Kitchen");
            DropForeignKey("Restaurant.Restaurant", "ClassificationID", "Restaurant.Classification");
            DropForeignKey("dbo.Platform", "LocationID", "dbo.Location");
            DropForeignKey("dbo.Platform", "LevelID", "dbo.Level");
            DropForeignKey("Hotel.Hotel", "PlatformID", "dbo.Platform");
            DropForeignKey("Hotel.Room", "HotelID", "Hotel.Hotel");
            DropForeignKey("Hotel.Room", "RoomTypeID", "Hotel.RoomType");
            DropForeignKey("Hotel.Room", "RoomCategoryID", "Hotel.RoomCategory");
            DropForeignKey("Hotel.Hotel", "HotelCategoryID", "Hotel.HotelCategory");
            DropForeignKey("Hall.Hall", "PlatformID", "dbo.Platform");
            DropIndex("Portfolio.Portfolio", new[] {"FormatID"});
            DropIndex("Restaurant.Restaurant", new[] {"KitchenID"});
            DropIndex("Restaurant.Restaurant", new[] {"ClassificationID"});
            DropIndex("Restaurant.Restaurant", new[] {"TypeID"});
            DropIndex("Restaurant.Restaurant", new[] {"PlatformID"});
            DropIndex("Hotel.Room", new[] {"RoomTypeID"});
            DropIndex("Hotel.Room", new[] {"RoomCategoryID"});
            DropIndex("Hotel.Room", new[] {"HotelID"});
            DropIndex("Hotel.Hotel", new[] {"HotelCategoryID"});
            DropIndex("Hotel.Hotel", new[] {"PlatformID"});
            DropIndex("Hall.Hall", new[] {"PlatformID"});
            DropIndex("dbo.Platform", new[] {"LocationID"});
            DropIndex("dbo.Platform", new[] {"LevelID"});
            DropIndex("dbo.Platform", new[] {"CityID"});
            DropTable("NonStandard.NonStandardType");
            DropTable("Portfolio.Portfolio");
            DropTable("Portfolio.Format");
            DropTable("Restaurant.RestaurantType");
            DropTable("Restaurant.Kitchen");
            DropTable("Restaurant.Classification");
            DropTable("Restaurant.Restaurant");
            DropTable("dbo.Location");
            DropTable("dbo.Level");
            DropTable("Hotel.RoomType");
            DropTable("Hotel.RoomCategory");
            DropTable("Hotel.Room");
            DropTable("Hotel.HotelCategory");
            DropTable("Hotel.Hotel");
            DropTable("Hall.Hall");
            DropTable("dbo.Platform");
            DropTable("dbo.City");
        }
    }
}