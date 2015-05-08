<Query Kind="FSharpProgram" />

let sqrt n = int(Math.Sqrt(double(n)))

let isPrime n =
    [2..sqrt n]
    |> Seq.filter (fun x -> n % x = 0)
    |> Seq.length = 0
    
Seq.unfold (fun n -> Some(n, n + 1)) 1
|> Seq.filter isPrime
|> Seq.nth 10001
|> Dump