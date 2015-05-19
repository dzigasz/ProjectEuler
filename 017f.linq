<Query Kind="FSharpProgram" />

let rec toWord x =
    match x with
    | x when x >= 1000 -> toWord (x / 1000) + "Thousand" + toWord (x % 1000)
    | x when x >= 100 -> toWord (x / 100) + "Hundred" + match x % 100 with
                                                            | 0 -> ""
                                                            | _ -> "And" + toWord (x % 100)
    | x when x >= 20 -> match x / 10 with
                        | 2 -> "Twenty" + toWord (x % 10)
                        | 3 -> "Thirty" + toWord (x % 10)
                        | 4 -> "Forty" + toWord (x % 10)
                        | 5 -> "Fifty" + toWord (x % 10)
                        | 6 -> "Sixty" + toWord (x % 10)
                        | 7 -> "Seventy" + toWord (x % 10)
                        | 8 -> "Eighty" + toWord (x % 10)
                        | 9 -> "Ninety" + toWord (x % 10)
                        | _ -> ""
    | x when x >= 1 -> match x with
                       | 1 -> "One"
                       | 2 -> "Two"
                       | 3 -> "Three"
                       | 4 -> "Four"
                       | 5 -> "Five"
                       | 6 -> "Six"
                       | 7 -> "Seven"
                       | 8 -> "Eight"
                       | 9 -> "Nine"
                       | 10 -> "Ten"
                       | 11 -> "Eleven"
                       | 12 -> "Twelve"
                       | 13 -> "Thirteen"
                       | 14 -> "Fourteen"
                       | 15 -> "Fifteen"
                       | 16 -> "Sixteen"
                       | 17 -> "Seventeen"
                       | 18 -> "Eighteen"
                       | 19 -> "Nineteen"
                       | _ -> ""
    | _ -> ""

[1..1000]
|> List.map toWord
|> List.sumBy (fun s -> s.Length)
|> Dump
