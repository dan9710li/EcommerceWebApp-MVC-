namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded, ReleasedDate, NumberInStock) VALUES('Hangover', 5, 2016-05-04, 2009-11-06, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
