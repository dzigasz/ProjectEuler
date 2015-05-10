<Query Kind="Statements" />

Func<int, int[]> numberAsDigits = n => n.ToString().Select(c => (int)char.GetNumericValue(c)).ToArray();

Enumerable.Range(2,1000000)
    .Where(n => n == numberAsDigits(n).Aggregate(0, (n1, n2) => n1 + (int)Math.Pow(n2, 5)))
    .Sum()
    .Dump();