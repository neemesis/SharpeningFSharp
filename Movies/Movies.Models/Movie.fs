namespace Movies.Models
open System

[<CLIMutable>]
type Movie = {
    adult: bool;
    backrop_path: string;
    budget: int;
    genres: Genre list;
    homepage: string;
    id: int;
    imdb_id: string;
    original_language: string;
    original_title: string;
    overview: string;
    popularity: double;
    poster_path: string;
    production_companies: Company list;
    production_countries: Country list;
    release_data: DateTime;
    revenue: int;
    runtime: int;
    spoken_languages: Language list;
    status: string;
    tagline: string;
    title: string;
    video: bool;
    vote_average: double;
    vote_count: int;
}