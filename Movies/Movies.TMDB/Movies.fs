module Movies.TMDB.Movies
open Movies.TMDB.Constants
open Newtonsoft.Json
open Movies.Models

let Search (x : string) =
    let qry = ["page", "1"; "query", x]
    let result = makeRequest SEARCHMOVIE qry "GET" ""
    
    //printfn "%A" result
    let movies : FindMovies = JsonConvert.DeserializeObject<FindMovies>(result);
    
    //printfn "Res: %A, Length: %A" movies.total_results movies.results.Length

    movies

let Get (x : int) =
    let result = makeRequest GETMOVIE List.empty "GET" (x.ToString())
    let movie = JsonConvert.DeserializeObject<Movie>(result);
    //printfn "%A" movie.original_title
    movie

let Reviews (x : int) =
    let result = makeRequest GETMOVIE List.empty "GET" (x.ToString() + REVIEWS)
    //printfn "%A" result
    
    let reviews = JsonConvert.DeserializeObject<ReviewsList>(result);

    reviews

let Images (x : int) =
    let result = makeRequest GETMOVIE List.empty "GET" (x.ToString() + IMAGES)
    //printfn "%A" result
    
    let images = JsonConvert.DeserializeObject<ImageList>(result);

    //printfn "%A, %A" images.backdrops.Length images.posters.Length
    images

let Similar (x : int) =
    let result = makeRequest GETMOVIE List.empty "GET" (x.ToString() + SIMILAR)
    //printfn "%A" result
    
    let movies : FindMovies = JsonConvert.DeserializeObject<FindMovies>(result);

    //printfn "%A" movies.results.Length
    movies

let Popular =
    let result = makeRequest GETPOPULARMOVIES List.empty "GET" ""
    //printfn "%A" result
    
    let movies : FindMovies = JsonConvert.DeserializeObject<FindMovies>(result);

    //printfn "%A" movies.results.Length
    movies