<Query Kind="FSharpProgram" />

let isPandigital x =
    if x < 10 || x > 987654321 then false
    else
        let str = x.ToString()
        [|1..str.Length|]
        |> Array.forall (fun n -> str.Contains(n.ToString()))

let isPrime n =
    let hasDivisors n =
        let max = int(sqrt(double(n)))
        Seq.unfold (fun i -> if i > max then None else Some(i, i+1)) 2
        |> Seq.exists (fun x -> n % x = 0)
    if n < 2 then false
    else not(hasDivisors n)
    
Seq.unfold (fun i -> Some(i, i-2)) 87654321 // 987654321
|> Seq.find (fun n -> isPandigital n && isPrime n)
|> Dump
