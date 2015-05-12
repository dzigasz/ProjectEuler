<Query Kind="FSharpProgram" />

let nextCollatz n =
    if n % 2L = 0L then n / 2L
    else 3L * n + 1L

let collatzSeq n =
    Seq.unfold (fun x -> if x = 0L then None elif x = 1L then Some(x, 0L) else Some(x, nextCollatz x)) n

[|1L..999999L|]
|> Seq.map (fun x -> (x, x |> collatzSeq |> Seq.length))
|> Seq.maxBy snd
|> Dump
