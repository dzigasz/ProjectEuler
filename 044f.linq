<Query Kind="FSharpProgram" />

let pentagonal =
    Seq.initInfinite (fun n -> n * (3*n - 1) / 2 )
    |> Seq.skip 1
    |> Seq.take 100
    
let isPentagonal n =
    pentagonal
    |> Seq.exists (fun p -> p = n)

pentagonal
|> Seq.collect (fun x -> pentagonal |> Seq.map (fun y -> (x, y, x+y, Math.Abs(x - y))))
//|> Seq.filter (fun (sum, minus) -> isPentagonal sum && isPentagonal minus)
|> Seq.distinct
|> Seq.sort
|> Dump
