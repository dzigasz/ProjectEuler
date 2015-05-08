<Query Kind="FSharpProgram" />

Seq.unfold (fun (cur, nxt) -> Some(cur, (nxt, cur + nxt))) (1, 2)
|> Seq.takeWhile (fun x -> x < 4000000)
|> Seq.filter (fun x -> x % 2 = 0)
|> Seq.sum
|> Dump