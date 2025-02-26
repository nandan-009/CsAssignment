using System.ComponentModel.DataAnnotations.Schema;

namespace MVCAssigment_4.Models
{
    
    public class MovieVM
    {
        
        public List<Movie> Movies { get; set; }
        public Movie Movie { get; set; }
    }
}
