<Query Kind="FSharpProgram" />

let isEvenlyDivided n dividers =
    dividers |> Seq.forall (fun d -> n % d = 0)

let smallestDividedByAll dividers =
    Seq.unfold (fun n -> Some(n, n + 1)) (Seq.max dividers)
    |> Seq.filter (fun x -> isEvenlyDivided x dividers)
    |> Seq.head
    
smallestDividedByAll [1..20] |> Dump