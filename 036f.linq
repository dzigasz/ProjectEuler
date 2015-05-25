<Query Kind="FSharpProgram" />

let isPalindromic (s:string) = 
    let cs = s.ToCharArray()
    Array.rev cs
    |> Array.zip cs
    |> Array.forall (fun (a, b) -> a = b)

[1..999999]
|> List.map (fun n -> n, n.ToString(), Convert.ToString(n, 2))
|> List.filter (fun (_, base10, base2) -> isPalindromic base10 && isPalindromic base2)
|> List.sumBy (fun (n, _, _) -> n)
|> Dump
