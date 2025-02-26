


namespace MVCAssigment_4.Models
{
    public class MovieDAO : IMovieDAO
    {
        private readonly MovieDBContext dbCtx;
        public MovieDAO(MovieDBContext dbctx)
        {
            this.dbCtx = dbctx;
        }
        

        public void AddMovie(Movie movie,int i)
        {
            movie.Id = i;
            dbCtx.Movies.Add(movie);    
            dbCtx.SaveChanges();
        }

        public List<Movie> GetAllMovies()
        {
            return dbCtx.Movies.ToList();
        }
    }
}
