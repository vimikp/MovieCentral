namespace MovieCentralOne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleaseDate = '2012-01-02 23:12:11.123', DateAdded = '2018-01-01 23:12:11.123', NumberInStock = 4  WHERE Id = 1");
            Sql("UPDATE Movies SET ReleaseDate = '2005-01-02 23:12:11.123', DateAdded = '2018-01-01 23:12:11.123', NumberInStock = 4  WHERE Id = 2");
            Sql("UPDATE Movies SET ReleaseDate = '2006-01-02 23:12:11.123', DateAdded = '2018-01-01 23:12:11.123', NumberInStock = 4  WHERE Id = 3");
            Sql("UPDATE Movies SET ReleaseDate = '2004-01-02 23:12:11.123', DateAdded = '2018-01-02 23:12:11.123', NumberInStock = 4  WHERE Id = 4");
            Sql("UPDATE Movies SET ReleaseDate = '2017-01-02 23:12:11.123', DateAdded = '2018-01-02 23:12:11.123', NumberInStock = 4  WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
