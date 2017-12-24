namespace Movies.Models

[<CLIMutable>]
type FindTV = {
    page: int;
    total_results: int;
    total_pages: int;
    results: TV list;
}