namespace Hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] data = { { 'a', 'b', 'c' },
              { 'q', 'w', 'e' } };

            Arr arr = new Arr(data);
            Console.WriteLine(arr[0]);

            Console.WriteLine("Number of consonant: " + arr.ConsonantCount);
        }
    }
}