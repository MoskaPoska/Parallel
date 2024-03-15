namespace Parallel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введиет число 2");
            int num2 = int.Parse(Console.ReadLine());

            string fileName = @"D:\5zadanie.txt";
           
                using (StreamWriter stream = new StreamWriter(fileName)) 
                {
                Parallel.For(num1, num2, i =>
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        stream.WriteLine($"{i} * {j} = {i * j}");
                       
                    }
                    stream.WriteLine();
                });
                }
            Console.WriteLine($"Результат записан в {fileName}");
        }

    }
}