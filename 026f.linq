<Query Kind="FSharpProgram" />

let rec cycle n =
    if n % 2I = 0I then cycle (n/2I)
    elif n % 5I = 0I then cycle (n/5I)
    else
        Seq.initInfinite (fun i -> i+1)
        |> Seq.find (fun x -> ((pown 10I x) - 1I) % n = 0I)
 
[1I..999I] 
|> Seq.maxBy cycle
|> Dump
