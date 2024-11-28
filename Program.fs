open System
// Define the Discriminated Union for Genre
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

// Define the Director record type
type Director = {
    Name: string
    Movies: int
}

// Define the Movie record type
type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}
// Create directors
let director1 = { Name = "Sian Heder"; Movies = 9 }
let director2 = { Name = "Kenneth Branagh"; Movies = 23 }
let director3 = { Name = "Adam McKay"; Movies = 27 }
let director4 = { Name = "Ryusuke Hamaguchi"; Movies = 16 }
let director5 = { Name = "Denis Villeneuve"; Movies = 24 }
let director6 = { Name = "Reinaldo Marcus Green"; Movies = 15 }
let director7 = { Name = "Paul Thomas Anderson"; Movies = 49 }
let director8 = { Name = "Guillermo Del Toro"; Movies = 22 }

// Create movies
let movies = [
    { Name = "CODA"; RunLength = 111; Genre = Drama; Director = director1; IMDBRating = 8.1 }
    { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = director2; IMDBRating = 7.3 }
    { Name = "Don’t Look Up"; RunLength = 138; Genre = Comedy; Director = director3; IMDBRating = 7.2 }
    { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = director4; IMDBRating = 7.6 }
    { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = director5; IMDBRating = 8.1 }
    { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = director6; IMDBRating = 7.5 }
    { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = director7; IMDBRating = 7.4 }
    { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = director8; IMDBRating = 7.1 }
]
//find the rating that is greater than 7.4
let probableOscarWinners = 
    movies 
    |> List.filter (fun movie -> movie.IMDBRating > 7.4)

printfn "Probable Oscar Winners:"
probableOscarWinners |> List.iter (fun movie -> printfn "- %s" movie.Name)

let convertRunLengthToHours (minutes: int) =
    let hours = minutes / 60
    let mins = minutes % 60
    sprintf "%dh %dmin" hours mins

let movieRunTimes =
    movies 
    |> List.map (fun movie -> sprintf "%s: %s" movie.Name (convertRunLengthToHours movie.RunLength))

printfn "\nMovie Run Times in Hours and Minutes:"
movieRunTimes |> List.iter (printfn "%s")
