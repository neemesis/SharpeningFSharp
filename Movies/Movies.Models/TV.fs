namespace Movies.Models

[<CLIMutable>]
type TV = {
    backrop_path: string;
    created_by: Person list;
    episode_run_time: int list;
    first_air_date: string;
    genres: Genre list;
    homepage: string;
    id: int;
    in_production: bool;
    languages: string list;
    last_air_date: string;
    name: string;
    networks: Network list;
    number_of_episodes: int;
    number_of_seasons: int;
    origin_country: string list;
    original_language: string;
    original_name: string;
    overview: string;
    popularity: double;
    poster_path: string;
    production_companies: Company list;
    seasons: Season list;
    status: string;
    Type: string;
    vote_average: double;
    vote_count: int;
}