// Learn more about F# at http://fsharp.org

open System
open Movies.Models
open FSharp.Data
open Newtonsoft.Json
open Movies.TMDB

[<EntryPoint>]
let main argv =
    //let qry = ["api_key", "45fb341c9e1114958b519e32556afaa1"; "language", "en-US"]
    //let url = "https://api.themoviedb.org/3/movie/550"
    //let response = Http.RequestString(url, query = qry, httpMethod = "GET" )

    //let movie = JsonConvert.DeserializeObject<Movie>(response);

    //printfn "Name: %A, Tagline: %A" movie.original_title movie.tagline
    //printfn "%A" movie.overview;


    //let searchedMovies = Movies.Search "Zodiac"

    //let movie = Movies.Get 550

    //let reviews = Movies.Reviews 550

    //let images = Movies.Images 550

    //let similar = Movies.Similar 550

    //let popular = Movies.Popular

    //let tv = TV.Get 1399

    //let tvImages = TV.Images 1399

    //let tvSimilar = TV.Similar 1399

    //let tvPopular = TV.Popular

    let tvSearch = TV.Search "Doctor Who"


    0 // return an integer exit code
