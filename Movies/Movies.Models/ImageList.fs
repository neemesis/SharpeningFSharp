namespace Movies.Models

[<CLIMutable>]
type ImageList = {
    id: int;
    backdrops: Backdrop list;
    posters: Poster list;
}