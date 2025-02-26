namespace MVCAssigment_4.Models
{
    public interface IMovieDAO
    {
        public List<Movie> GetAllMovies();
        public void AddMovie(Movie movie,int i);
    }
}
