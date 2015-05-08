<Query Kind="FSharpProgram" />

let sumSquare ns =
    ns
    |> Seq.map (fun x -> x*x)
    |> Seq.sum

let squareSum ns =
    let n = ns |> Seq.sum
    n*n
    
let xs = [1..100]
squareSum xs - sumSquare xs |> Dump