using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAssigment_4.Models
{
    [Table("movie")]
    public class Movie
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("genre")]
        public string Genre { get; set; }
        [Column("year")]
        public int Year { get; set; }
        [Column("producer")]
        public string Producer { get; set; }
    }
}
