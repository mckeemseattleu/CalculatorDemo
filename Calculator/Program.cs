using System;
using System.IO;
int result = 20 + 22;
Console.WriteLine($"20 + 22 = {result}");
File.WriteAllText("calculator-result.txt", $"20 + 22 = {result}");