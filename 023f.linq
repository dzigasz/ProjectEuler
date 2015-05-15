<Query Kind="FSharpProgram" />

let divisorsOf n =
    [|1..int(Math.Sqrt(double(n)))|]
    |> Seq.filter (fun x -> n % x = 0)
    |> Seq.collect (fun x -> [x; n/x])
    |> Seq.distinct
    
let properSum n = (divisorsOf n |> Seq.sum) - n

let isAbundant n = (properSum n) > n

let abundantNumbers = [1..28123] |> Seq.filter isAbundant |> Seq.toList
    
let sumAbundant =
    abundantNumbers
    |> Seq.collect (fun x -> abundantNumbers |> Seq.map (fun y -> x + y))
    |> Seq.filter (fun x -> x <= 28123)
    |> Seq.distinct
    |> Seq.sum
    
let sumAll = ([1..28123] |> Seq.sum)

sumAll - sumAbundant |> Dump
