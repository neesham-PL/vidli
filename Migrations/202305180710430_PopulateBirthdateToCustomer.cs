namespace vidli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdateToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1981-01-01' WHERE Id = 1");
            Sql("UPDATE Customers SET Birthdate = '1983-01-01' WHERE Id = 2");
            Sql("UPDATE Customers SET Birthdate = '1982-01-01' WHERE Id = 3");
           
        }
        
        public override void Down()
        {
        }
    }
}
