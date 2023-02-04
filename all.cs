using System; // все работает только с положительными числами

class Program
{
    static void output_mass(int[,] mass)
    {
        for (int i = 0; i < mass.GetLength(0); i++)

        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                Console.Write($"{mass[i, j]}\t");
            }
            Console.WriteLine();
            
        }
    }
    static void snake(ref int[,] mass)
    {
        for (int i = 0; i < mass.GetLength(1); i++)

        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                if (i % 2 != 0) mass[i, j] =  mass.GetLength(1)*(i+1)-j;
                else mass[i, j] = j + mass.GetLength(1) * i+1;
            }

        }

    }
    static int max_elem_from_zone(int [, ] mass)
    {
        int res = 0;
        for (int i =0; i < mass.GetLength(0); i++)
        {
            for (int j = mass.GetLength(1)-i; j < mass.GetLength(1); j++)
            {
                if (i < j && (i + j) <= mass.GetLength(0)-2) Console.WriteLine(mass[i, j]);
                else if (i > j&&(i + j) >= mass.GetLength(0) - 2) Console.WriteLine(mass[i, j]);
            }
        }
        return res;

    }
    public static void Main()
    {
        int[,] mass = new int[4, 4];
        snake(ref mass);
        int[,] mass1 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } , { 13, 14, 15, 16 } };
        output_mass(mass1);
        max_elem_from_zone(mass1);
    }
}
