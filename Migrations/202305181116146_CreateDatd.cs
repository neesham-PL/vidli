namespace vidli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                {
                    Id = c.Byte(nullable: false),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }
        
        public override void Down()
        {
           
        }
    }
}
