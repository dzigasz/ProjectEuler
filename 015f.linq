<Query Kind="FSharpProgram" />

let rec fact n = 
    if n <= 1I then 1I
    else n * fact(n-1I)
    
let combos n k = 
    fact(n) / (fact(k) * fact(n-k))

combos 40I 20I
|> Dump
