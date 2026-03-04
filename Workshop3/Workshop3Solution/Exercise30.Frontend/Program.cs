/*
 do a program that makes operations in an array of order N, (N terms x N terms), 
 fill the array with the formula: Cell[i][j] = (i + 1) - j,
 then show the array, with the summatory of the array elements and
 then, show the highest and lowest elementsin the array.
*/
using Shared;


var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var order = ConsoleExtension.GetInt("Ingrese el orden de la matriz: ");


    Console.WriteLine($"La sumatoria es: ");
    Console.WriteLine($"El valor máximo es: ");
    Console.WriteLine($"El valor mínimo es: ");
} while(answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Gracias por usar el programa! Game over :)");
