namespace Exercise35.Backend;

public class NumberToDecompose
{
    //fields
    private int _number;

    //constructors
    public NumberToDecompose(int number)
    {
        _number = number;
    }
    
    //properties
    public int Number
    {
        get => _number;
        set => _number = ValidateNumber(value);
    }

    //methods
    //overrides
    public override string ToString()
    {
        return $"{PrintDecomposition()}";
    }

    //public methods
    public List<int> Decompose()
    {
        List<int> factors = new List<int>();
        int divisor = 2;
        int numberToDecompose = Number;
        while (numberToDecompose > 1)
        {
            if (numberToDecompose % divisor == 0)
            {
                factors.Add(divisor);
                numberToDecompose /= divisor;
            }
            else
            {
                divisor++;
            }
        }
        return factors;
    }

    public string PrintDecomposition()
    {
        List<int> factors = Decompose();
        return $"{Number} = {string.Join(" x ", factors)}";
    }

    //private methods
    private int ValidateNumber(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentException("El número a descomponer no puede ser 0.");
        }
        return number;
    }
}
