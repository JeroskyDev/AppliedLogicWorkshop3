//Do a program that decomposes a number into its factors
using Exercise35.Backend;
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Ingrese el número a descomponer: ");
    var numberToDecompose = new NumberToDecompose(n);

    //print from backend
    numberToDecompose.Decompose();
    Console.WriteLine(numberToDecompose.ToString());
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?....: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Gracias por usar el programa! Game over :)");
