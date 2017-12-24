namespace Movies.Models

[<CLIMutable>]
type Review = {
    id: string;
    author: string;
    content: string;
    url: string;
}