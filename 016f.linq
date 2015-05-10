<Query Kind="FSharpProgram" />

open System.Numerics

BigInteger.Pow(BigInteger(2), 1000).ToString().ToCharArray()
|> Seq.map (fun c -> Char.GetNumericValue(c))
|> Seq.sum
|> Dump