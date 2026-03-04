//Do a program that decomposes a number into its factors
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Ingrese el número a descomponer: ");

    Console.WriteLine($"{n} =  ");

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Gracias por usar el programa! Game over :)");
