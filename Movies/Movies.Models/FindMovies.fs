namespace Movies.Models

[<CLIMutable>]
type FindMovies = {
    page: int;
    total_results: int;
    total_pages: int;
    results: Movie list;
}