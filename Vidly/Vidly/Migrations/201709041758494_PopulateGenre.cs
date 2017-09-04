namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name)" +
                "VALUES('Comedy'), ('Action'), ('Family'), ('Romance'), ('Horror'), ('Sci-Fi'), ('Fantasy')");
        }
        
        public override void Down()
        {
        }
    }
}
