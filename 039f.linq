<Query Kind="FSharpProgram" />

let rightTriangles p =
    [1..p/2]
    |> Seq.collect (fun a -> [1..p/4] |> Seq.map (fun b -> (a, b, p-a-b)))
    |> Seq.filter (fun (a, b, c) -> a*a + b*b = c*c)
    
[3..1000]
|> List.maxBy (fun p -> rightTriangles p |> Seq.length)
|> Dump
