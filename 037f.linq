<Query Kind="FSharpProgram" />

let isPrime n =
    let hasDivisors n =
        [2..int(sqrt(double(n)))]
        |> Seq.exists (fun x -> n % x = 0)
    if n < 2 then false
    else not(hasDivisors n)

let truncate n =
    let str = n.ToString()    
    Seq.concat [
        seq { for i in 1..str.Length-1 do yield int(str.Substring(0, i)) };
        seq { for i in 0..str.Length-1 do yield int(str.Substring(i, str.Length-i)) } ]

[8..999999]
|> List.filter (fun n -> n |> truncate |> Seq.forall isPrime)
|> List.sum
|> Dump
