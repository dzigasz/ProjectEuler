<Query Kind="FSharpProgram" />

let TriangleSeq =
    Seq.unfold (fun (s, i) -> Some(s, (s+i, i+1L))) (1L, 2L)
    
let NOfDivisors n =
    [|1L..int64(Math.Sqrt(double(n)))|]
    |> Seq.filter (fun x -> n % x = 0L)
    |> Seq.collect (fun x -> [x; n/x])
    |> Seq.length

TriangleSeq
|> Seq.skipWhile (fun x -> NOfDivisors x < 500)
|> Seq.head
|> Dump
