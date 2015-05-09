<Query Kind="FSharpProgram" />

let sqrt n = int64(Math.Sqrt(double(n)))

let isPrime n =
    [2L..sqrt n]
    |> Seq.filter (fun x -> n % x = 0L)
    |> Seq.length = 0
    
seq { for n in 2L..2000000L do if isPrime(n) then yield n }
|> Seq.sum
|> Dump