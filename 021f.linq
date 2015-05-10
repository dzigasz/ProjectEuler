<Query Kind="FSharpProgram" />

let divisorsOf n =
    [1..n/2] |> Seq.filter (fun x -> n % x = 0)
    
let d n =
    divisorsOf n |> Seq.sum
    
let isAmicable n =
    let a = d n
    a <> n && d a = n
    
[1..9999] |> List.filter isAmicable |> List.sum |> Dump