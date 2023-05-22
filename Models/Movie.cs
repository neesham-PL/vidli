using System;
using System.ComponentModel.DataAnnotations;

namespace vidli.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }


        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public int NumberStock { get; set; }
        public byte NumberAvailable { get; set; }

        //protected void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
        //}

    }
}