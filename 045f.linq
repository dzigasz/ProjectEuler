<Query Kind="FSharpProgram" />

let T n = n * (n + 1L) / 2L
let P n = n * (3L*n - 1L) / 2L
let H n = n * (2L*n - 1L)

let triangle = [1L..100000L] |> List.map T
let pentagonal = [1L..100000L] |> List.map P
let hexagonal = [1L..100000L] |> List.map H

triangle
|> List.find (fun t -> t > 40755L
                    && pentagonal |> List.exists ((=) t)
                    && hexagonal |> List.exists ((=) t))
|> Dump
