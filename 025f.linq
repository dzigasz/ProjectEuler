<Query Kind="FSharpProgram" />

open System.Numerics

let BigFib = 
    Seq.unfold (fun pair -> Some(fst pair, (snd pair, fst pair + snd pair))) (BigInteger(1), BigInteger(1))
    
BigFib
|> Seq.mapi (fun i x -> (i+1, x.ToString().Length))
|> Seq.skipWhile (fun x -> snd x < 1000)
|> Seq.take 1
|> Dump