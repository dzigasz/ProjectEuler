<Query Kind="FSharpProgram" />

let rec fac n =
    if n < 1 then 1
    else n * fac(n-1)

let isCurious n =
    let sum = n.ToString()
        |> Seq.map (fun c -> int(Char.GetNumericValue(c)))
        |> Seq.map fac
        |> Seq.sum
    n = sum

[3..1000000]
|> Seq.filter isCurious
|> Seq.sum
|> Dump