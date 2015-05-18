<Query Kind="FSharpProgram" />

let rec insertions x = function
    | []             -> [[x]]
    | (y :: ys) as l -> (x::l)::(List.map (fun x -> y::x) (insertions x ys))

let rec permutations = function
    | []      -> seq [ [] ]
    | x :: xs -> Seq.concat (Seq.map (insertions x) (permutations xs))
    
[0..9]
|> permutations
|> Seq.map (fun ns -> int64((ns |> Seq.fold (fun (a:StringBuilder) c -> a.Append(c.ToString())) (new StringBuilder())).ToString()))
|> Seq.sort
|> Seq.nth 999999
|> Dump
