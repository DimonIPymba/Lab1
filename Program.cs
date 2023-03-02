namespace Program
{
    internal class Program
    {
        delegate int IntGetter();
        delegate int AverageFromGetters(IntGetter[] valueGetter);
        delegate int Average(int a, int b, int c);

        public static void Main()
        {
            var Add = (int a, int b) => a + b;
            var Sub = (int a, int b) => a - b;
            var Mul = (int a, int b) => a * b;
            var Div = (int a, int b) => a / b;

             Console.WriteLine(Add(1, 6));
             Console.WriteLine(Sub(5, 6));
             Console.WriteLine(Mul(1, 5));
             Console.WriteLine(Div(4, 5));

            IntGetter getter = () => Random.Shared.Next();

            AverageFromGetters averageFromGetters = (items) =>
            {
              int sum = 0;
              foreach(var getter in items)
            {
               sum += getter();
            }
              return sum / items.Length;
            };

            Func<int, int, int, int> func = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3;
            };
            Console.WriteLine(func(3, 4, 5));
        }
    }
}
