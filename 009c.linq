<Query Kind="Statements" />

var n = 1000;

var tris = from x in Enumerable.Range(1, n)
           from y in Enumerable.Range(1, n - x)
           from z in Enumerable.Range(1, n - x - y)
           where x + y + z == n
           where x*x + y*y == z*z
           select new { x, y, z };

tris.Select(_ => _.x * _.y * _.z)
    .First()
    .Dump();