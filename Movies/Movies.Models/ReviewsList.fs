namespace Movies.Models

[<CLIMutable>]
type ReviewsList = {
    id: int;
    page: int;
    total_results: int;
    total_pages: int;
    results: Review list;
}