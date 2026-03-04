namespace Exercise30.Backend;

public class Matrix
{
    //fields
    private int _order;
    private int[,] _array;

    //constructor
    public Matrix(int order)
    {
        Order = order;
        CreateMatrix(); //create array instantly having the order of the matrix
    }
    //properties
    public int Order
    {
        get => _order;
        set => _order = ValidateNForOrder(value);
    }

    public int[,] Array 
    {
        get => _array; 
        set => _array = ValidateArray(value); 
    }

    //methods
    //override methods
    public override string ToString()
    {
        return $"{PrintMatrix()}" +
            $"\nLa sumatoria es: {SumMatrix()}" +
            $"\nEl valor máximo es: {MaxValue()}" +
            $"\nEl valor mínimo es: {MinValue()}";
    }

    //public methods
    public int[,] CreateMatrix() //[,] means is a bidimensional array
    {
        Array = new int[Order, Order];
        for (int i = 0; i < Order; i++)
        {
            for (int j = 0; j < Order; j++)
            {
                Array[i, j] = (i + 1) - j;
            }
        }
        return Array;
    }

    public string PrintMatrix()
    {
        string cell = string.Empty;
        for (int i = 0; i < Array.GetLength(0); i++) //GetLength serves for looking for the length of the dimension of the array, with 0 being the first dimension (the horizontal or rows) and 1 being the second dimension (the vertical or columns)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                cell += $"{Array[i, j]}\t";
            }
            cell += "\n";
        }
        return cell; 
    }

    public int SumMatrix()
    {
        int sum = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                sum += Array[i, j];
            }
        }
        return sum;
    }

    public int MaxValue()
    {
        int max = Array[0, 0];
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                if (Array[i, j] > max)
                {
                    max = Array[i, j];
                }
            }
        }
        return max;
    }

    public int MinValue()
    {
        int min = Array[0, 0];
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                if (Array[i, j] < min)
                {
                    min = Array[i, j];
                }
            }
        }
        return min;
    }

    //private methods
    private int ValidateNForOrder(int order)
    {
        if (order < 0)
        {
            throw new ArgumentException("El orden de la matriz no puede ser negativo.");
        }
        return order;
    }

    private int[,] ValidateArray(int[,] value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value), "El array no puede ser nulo.");
        } 
        return value;
    }
}
