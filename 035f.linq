<Query Kind="FSharpProgram" />

let isPrime n =
    let hasDivisors n =
        [2..int(sqrt(double(n)))]
        |> Seq.exists (fun x -> n % x = 0)
    not(hasDivisors n)

let isCircularPrime n =
    let rotations n = 
        let digits = n.ToString().ToCharArray()
        [0..digits.Length-1]
        |> List.map (fun r -> digits |> Array.permute (fun i -> (i + r) % digits.Length))
        |> List.map (fun ds -> String.Join("", ds) |> Int32.Parse)
    rotations n
    |> List.forall isPrime

[2..999999]
|> List.filter isPrime
|> List.filter isCircularPrime
|> Dump
