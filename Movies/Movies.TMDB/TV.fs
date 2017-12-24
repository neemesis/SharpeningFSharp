module Movies.TMDB.TV
open Movies.TMDB.Constants
open Newtonsoft.Json
open Movies.Models

let Get (x : int) =
    let result = makeRequest GETTV List.empty "GET" (x.ToString())
    let tv = JsonConvert.DeserializeObject<TV>(result);
    //printfn "%A" tv.original_name
    tv

let Images (x : int) =
    let result = makeRequest GETTV List.empty "GET" (x.ToString() + IMAGES)
    //printfn "%A" result
    
    let images = JsonConvert.DeserializeObject<ImageList>(result);

    printfn "%A, %A" images.backdrops.Length images.posters.Length
    images

let Similar (x : int) =
    let result = makeRequest GETTV List.empty "GET" (x.ToString() + SIMILAR)
    //printfn "%A" result
    
    let tvs : FindTV = JsonConvert.DeserializeObject<FindTV>(result);

    //printfn "%A" movies.results.Length
    tvs

let Popular =
    let result = makeRequest GETPOPULARTV List.empty "GET" ""
    //printfn "%A" result
    
    let tvs : FindTV = JsonConvert.DeserializeObject<FindTV>(result);

    //printfn "%A" tvs.results.Length
    tvs

let Search (x : string) =
    let qry = ["page", "1"; "query", x]
    let result = makeRequest SEARCHTV qry "GET" ""
    
    //printfn "%A" result
    let tvs : FindTV = JsonConvert.DeserializeObject<FindTV>(result);
    
    //printfn "Res: %A, Length: %A" tvs.total_results tvs.results.Length

    tvs