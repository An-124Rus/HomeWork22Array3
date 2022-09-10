internal class Program
{
    private static void Main(string[] args)
    {
        int minValue = 0;
        int maxValue = 100;
        int maxNumber;

        Random random = new Random();

        Console.WriteLine("Введите длину массива: ");
        int arrayLength = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[arrayLength];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minValue, maxValue);

            Console.Write($"{array[i]}  ");
        }

        Console.WriteLine();

        if (array[0] > array[1])
        {
            Console.Write($"{array[0]}  ");
        }

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1] && array[i] > array[i - 1])
            {
                maxNumber = array[i];
                Console.Write($"{maxNumber}  ");
            }
        }

        if (array[array.Length - 1] > array[array.Length - 2])
        {
            Console.Write($"{array[array.Length - 1]}  ");
        }
    }
}