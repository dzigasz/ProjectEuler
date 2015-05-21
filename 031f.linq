<Query Kind="FSharpProgram" />

let coins = [1; 2; 5; 10; 20; 50; 100; 200]
let total = 200

let rec count n m =
    if n = 0 then 1
    elif n < 0 then 0
    elif (m <= 0 && n >= 1) then 0
    else (count n (m-1)) + (count (n - coins.[m-1]) m)
    
count total coins.Length
|> Dump
