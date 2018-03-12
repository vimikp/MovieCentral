namespace MovieCentralOne.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirthDateToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '2000-01-02 23:12:11.123' WHERE Id = 1");
           
        }
        
        public override void Down()
        {
        }
    }
}
