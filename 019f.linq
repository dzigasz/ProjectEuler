<Query Kind="FSharpProgram" />

let start =
    DateTime(1901, 1, 1)

let finish =
    DateTime(2000, 12, 31)

let days =
    Seq.unfold (fun day -> if day > finish then None else Some(day, day.AddDays(1.))) start
    
days
|> Seq.filter (fun day -> day.DayOfWeek = DayOfWeek.Sunday && day.Day = 1)
|> Seq.length
|> Dump
