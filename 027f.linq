<Query Kind="FSharpProgram" />

let sqrt n = int(Math.Sqrt(double(n)))

let isPrime n =
    if n <= 1 then false
    else
        [2..sqrt n]
        |> Seq.filter (fun x -> n % x = 0)
        |> Seq.length = 0
    
let formula a b n = n*n + a*n + b

let consecPrimes a b = 
    [0..100]
    |> Seq.map (fun n -> formula a b n)
    |> Seq.takeWhile (fun x -> isPrime(x))
    |> Seq.length

seq [-1000..1000]
|> Seq.collect (fun a -> seq [-1000..1000] |> Seq.map (fun b -> a, b))
|> Seq.map (fun (a, b) -> a, b, a*b, consecPrimes a b)
|> Seq.maxBy (fun (_, _, _, n) -> n)
|> Dump
