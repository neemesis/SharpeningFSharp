namespace Movies.Models

[<CLIMutable>]
type Person = {
    id: int;
    name: string;
    gender: int;
    profile_path: string;
}