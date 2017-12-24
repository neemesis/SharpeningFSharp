namespace Movies.Models

[<CLIMutable>]
type Backdrop = {
    aspect_ratio: double;
    file_path: string;
    height: int;
    //iso_639_1: string;
    vote_average: double;
    vote_count: int;
    width: int;
}