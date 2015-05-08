<Query Kind="FSharpProgram" />

let sqrt n = int64(Math.Sqrt(double(n)))

let isPrime n =
    [2L..sqrt n]
    |> Seq.filter (fun x -> n % x = 0L)
    |> Seq.length = 0

let primeFactorsOf n =
    [2L..sqrt n]
    |> Seq.filter (fun x -> n % x = 0L)
    |> Seq.filter isPrime

primeFactorsOf 600851475143L
|> Seq.max
|> Dump
