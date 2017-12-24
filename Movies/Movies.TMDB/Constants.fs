module Movies.TMDB.Constants
open FSharp.Data

let BASEURL = "http://api.themoviedb.org/3/"
let APIKEY = "API_KEY_FROM_TMDB"

let MOVIESURL = BASEURL + "movie/"
let MOVIEREVIEWSURL = "/reviews"
let MOVIEIMAGESURL = "/images"

let TVURL = BASEURL + "tv/"
let TVIMAGESURL = "/images"

let SEARCHBYIDURL = BASEURL + "find/" // by ID

let SEARCHMOVIE = BASEURL + "search/movie/"
let GETMOVIE = BASEURL + "movie/"
let GETPOPULARMOVIES = BASEURL + "movie/popular"
let SEARCHTV = BASEURL + "search/tv/"

let REVIEWS = "/reviews"
let IMAGES = "/images"
let SIMILAR = "/similar"

let GETTV = BASEURL + "tv/"
let GETPOPULARTV = BASEURL + "tv/popular"

let makeRequest url (qry : (string * string) list) method path =
    printfn "URL: %A" (url + path)
    //let qry2 = ("api_key", APIKEY) :: ("language", "en-US") :: qry
    let qry2 = ("api_key", APIKEY) :: qry
    printfn "QUERY: %A" qry2
    Http.RequestString(url + path, query = qry2, httpMethod = method)