namespace vidli.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class populateMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name,GenreId, ReleaseDate,DateAdded, NumberStock) VALUES('Ice Age',1,'10-10-2004','10-1-2019',14)");
            Sql("INSERT INTO Movies(Name,GenreId, ReleaseDate,DateAdded, NumberStock) VALUES('Andaz Apna Apna',2,'1-10-1994','10-1-2019',9)");
            Sql("INSERT INTO Movies(Name,GenreId, ReleaseDate,DateAdded, NumberStock) VALUES('Furious 7',3,'10-10-2018','10-1-2020',19)");
            Sql("INSERT INTO Movies(Name,GenreId, ReleaseDate,DateAdded, NumberStock) VALUES('Conjuring 2',4,'10-10-2019','1-10-2023',4)");
            Sql("INSERT INTO Movies(Name,GenreId, ReleaseDate,DateAdded, NumberStock) VALUES('Drishyam 2',5,'10-01-2022','05-05-2022',11)");
            Sql("INSERT INTO Movies(Name,GenreId, ReleaseDate,DateAdded, NumberStock) VALUES('Kal Ho Na Ho',6,'03-07-2003','10-09-2010',6)");
            Sql("INSERT INTO Movies(Name,GenreId, ReleaseDate,DateAdded, NumberStock) VALUES('Wall-E',1,'05-04-2004','01-09-2009',14)");
        }

        public override void Down()
        {
        }
    }
}
