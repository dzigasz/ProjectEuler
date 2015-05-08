<Query Kind="FSharpProgram" />

[| 1..999 |]
|> Array.filter (fun x -> x % 3 = 0 || x % 5 = 0)
|> Array.sum
|> Dump