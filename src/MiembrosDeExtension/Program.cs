var ints = new[] { 1, 2, 3, 4, 5, 6 };

Console.WriteLine(ints.Csv);
Console.WriteLine();
ints.GetEven().ToList().ForEach(Console.WriteLine);
Console.WriteLine();
ints.GetOdd().ToList().ForEach(Console.WriteLine);
public static class MyExtensions
{
    extension(IEnumerable<int> numbers)
    {
        public string Csv => string.Join(",", numbers);

        public IEnumerable<int> GetEven()
        {
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }

        public IEnumerable<int> GetOdd()
        {
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    yield return number;
                }
            }
        }
    }
}