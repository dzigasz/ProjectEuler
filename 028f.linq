<Query Kind="FSharpProgram" />

let rec diagonals start step =
    seq { yield start
          yield start + step
          yield start + 2*step
          yield start + 3*step 
          yield! diagonals (start + 4*step) (step+2) }
    
diagonals 1 2
|> Seq.take 2001
|> Seq.sum
|> Dump
