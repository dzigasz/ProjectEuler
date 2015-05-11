<Query Kind="Statements" />

var seq = Enumerable.Range(0, 1000000)
                    .Aggregate(new StringBuilder(), (sb, s) => sb.Append(s))
                    .ToString()
                    .ToCharArray()
                    .Select(c => (int)Char.GetNumericValue(c))
                    .ToArray();
                    
var x = seq[1] * seq[10] * seq[100] * seq[1000] * seq[10000] * seq[100000] * seq[1000000];

Console.WriteLine(x);