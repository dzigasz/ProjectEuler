<Query Kind="FSharpProgram" />

[2.0..100.0]
|> Seq.collect (fun x -> [2.0..100.0] |> Seq.map (fun y -> (x,y)))
|> Seq.map (fun (x,y) -> x**y)
//|> Seq.sort
|> Seq.distinct
|> Seq.length
|> Dump
