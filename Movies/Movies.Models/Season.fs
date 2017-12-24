namespace Movies.Models
open System

[<CLIMutable>]
type Season = {
    id: int;
    aid_date: DateTime;
    episode_count: int;
    poster_path: string;
    season_number: int;
}