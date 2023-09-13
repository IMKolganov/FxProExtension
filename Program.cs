// See https://aka.ms/new-console-template for more information
using FxPro;

Console.WriteLine("Hello, World!");

var input = "abcde";
var result = input.Replace2("bc", "y");

Console.WriteLine(result);



input = "aabb";
result = input.Replace2("aab", "xyz");
Console.WriteLine(result);

input = "aaaa";
result = input.Replace2("aa", "b");
Console.WriteLine(result);



input = "ababa";
result = input.Replace2("aba", "c");
Console.WriteLine(result);


Console.WriteLine("FxPro is done!!!");
Console.ReadLine();