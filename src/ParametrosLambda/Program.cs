var e = new Ejemplo();

var ints = new[] { 1, 2, 3, 4, 5, 6 };

string result;
e.ConvertToCsv(ints, out result);
Console.WriteLine(result);

class Ejemplo
{
    public ToCsv ConvertToCsv = (numbers, out result) => result = string.Join(",", numbers);
}


public delegate void ToCsv(int[] numbers, out string result);