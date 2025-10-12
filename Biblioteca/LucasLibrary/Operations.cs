namespace LucasLibrary;

public class Operations
{
    public static double[] CreateDoubleArray(int leng, bool randomize)
    {
        double[] result = new double[leng];

        if (randomize)
        {
            Random x = new();
            for (int i = 0; i < leng; i++)
            {
                result[i] = x.NextDouble();
            }
        }

        return result;
    }

    public static int[] CreateIntArray(int leng, int minNumber, int maxNumber, bool randomize)
    {
        int[] result = new int[leng];

        if (randomize)
        {
            Random x = new();
            for (int i = 0; i < leng; i++)
            {
                result[i] = x.Next(minNumber, maxNumber + 1);
            }
        }

        return result;
    }

    public static void ShowArray(double[] array)
    {
        Console.WriteLine("\n");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i],3:F2}");
        }

        Console.ReadKey();
        Console.Clear();
    }

    public static void ShowArray(int[] array)
    {
        Console.WriteLine("\n");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i],3}");
        }

        Console.ReadKey();
        Console.Clear();
    }
}
