<Query Kind="FSharpProgram" />

open System.Numerics

let sum =
    [1I..1000I]
    |> Seq.map (fun x -> BigInteger.Pow(x, int(x)))
    |> Seq.sum
    
new String(
    sum.ToString().ToCharArray()
    |> Array.rev
    |> Seq.take 10
    |> Seq.toArray
    |> Array.rev)
|> Dump
