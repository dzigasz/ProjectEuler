<Query Kind="FSharpProgram" />

let fractions = 
    [11.0..99.0]
    |> Seq.collect (fun n -> [n+1.0..99.0] |> Seq.map (fun d -> n, d))

let cancel (n, d) =
    let nStr, dStr = n.ToString(), d.ToString()
    if nStr.[0] = dStr.[0] then Some(Char.GetNumericValue(nStr.[1]), Char.GetNumericValue(dStr.[1]))
    elif nStr.[0] = dStr.[1] then Some(Char.GetNumericValue(nStr.[1]), Char.GetNumericValue(dStr.[0]))
    elif nStr.[1] = dStr.[0] then Some(Char.GetNumericValue(nStr.[0]), Char.GetNumericValue(dStr.[1]))
    else None

fractions
|> Seq.map (fun (n, d) -> n, d, cancel (n, d))
|> Seq.filter (fun (_, _, c) -> c <> None)
|> Seq.map (fun (n, d, Some(cn, cd)) -> n/d, cn/cd)
|> Seq.filter (fun (x, cx) -> x = cx)
|> Seq.map (fun (x, cx) -> cx)
|> Seq.reduce (*)
|> Dump
