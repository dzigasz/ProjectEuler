<Query Kind="FSharpProgram" />

let rec insertions x = function
    | []             -> [[x]]
    | (y :: ys) as l -> (x::l)::(List.map (fun x -> y::x) (insertions x ys))

let rec permutations = function
    | []      -> seq [ [] ]
    | x :: xs -> Seq.concat (Seq.map (insertions x) (permutations xs))
    
[0..9]
|> permutations
|> Seq.map (fun ns -> (ns |> Seq.fold (fun (a:StringBuilder) c -> a.Append(c.ToString())) (new StringBuilder())).ToString())
|> Seq.filter (fun n ->
    int(n.Substring(1, 3)) % 2 = 0 && 
    int(n.Substring(2, 3)) % 3 = 0 && 
    int(n.Substring(3, 3)) % 5 = 0 && 
    int(n.Substring(4, 3)) % 7 = 0 && 
    int(n.Substring(5, 3)) % 11 = 0 && 
    int(n.Substring(6, 3)) % 13 = 0 && 
    int(n.Substring(7, 3)) % 17 = 0)
|> Seq.map int64
|> Seq.sum
|> Dump
