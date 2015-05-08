<Query Kind="FSharpProgram" />

let isPalindrome n =
    let str = n.ToString().ToCharArray()
    str = Array.rev str
    
[1..999]
|> List.collect (fun x -> [1..999] |> List.map (fun y -> x * y))
|> List.filter isPalindrome
|> List.max
|> Dump