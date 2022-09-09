internal class Program
{
    private static void Main(string[] args)
    {
        int minValue = 0;
        int maxValue = 100;
        int maxNumber;

        Random random = new Random();

        Console.WriteLine("Введите длину массива: ");
        int rowLenth = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[rowLenth];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minValue, maxValue);

            Console.Write($"{array[i]}  ");
        }

        Console.WriteLine();

        maxNumber = array[0];

        if (maxNumber > array[1])
        {
            Console.Write($"{maxNumber}  ");
        }
        else
        {
            maxNumber = array[1];
            Console.Write($"{maxNumber}  ");
        }

        for (int i = 2; i < array.Length - 1; i++)
        {
            if (maxNumber > array[i + 1] && maxNumber > array[i - 1])
            {
                maxNumber = array[i];
                Console.Write($"{maxNumber}  ");
            }
            else
            {
                maxNumber = array[i + 1];
            }
        }

        if (maxNumber > array[rowLenth - 1])
        {
            Console.Write($"{maxNumber}  ");
        }
        else
        {
            maxNumber = array[rowLenth - 1];
            Console.Write($"{maxNumber}  ");
        }
    }
}