<Query Kind="FSharpProgram" />

let isPandigital x =
    if x < 10 || x > 987654321 then false
    else
        let str = x.ToString()
        [|1..str.Length|]
        |> Array.forall (fun n -> str.Contains(n.ToString()))

let concatProduct i n = 
    let str = String.Concat([|1..i|] |> Array.map (fun m -> (m*n).ToString()))
    if str.Length > 9 then None
    else Some(int(str), n+1)

[2..5]
|> Seq.collect (fun n -> Seq.unfold (fun i -> (concatProduct n i)) 1)
|> Seq.filter isPandigital
|> Seq.sortBy (~-)
|> Dump
