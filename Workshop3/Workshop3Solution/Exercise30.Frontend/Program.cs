/*
 do a program that makes operations in an array of order N, (N terms x N terms), 
 fill the array with the formula: Cell[i][j] = (i + 1) - j,
 then show the array, with the summatory of the array elements and
 then, show the highest and lowest elementsin the array.
*/
using Exercise30.Backend;
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var order = ConsoleExtension.GetInt("Ingrese el orden de la matriz: ");
    var matrix = new Matrix(order);

    //print from backend
    matrix.CreateMatrix();

    Console.WriteLine(matrix.ToString());

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?....: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Gracias por usar el programa! Game over :)");

