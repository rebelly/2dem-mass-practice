using System; 

class Program
{
    static void output_mass(string[,] mass)
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
    static void snake(ref string[,] mass)
    {
        for (int i = 0; i < mass.GetLength(1); i++)

        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                if (i % 2 != 0) mass[i, j] = Convert.ToString( mass.GetLength(1) * (i + 1) - j);
                else mass[i, j] = Convert.ToString(j + mass.GetLength(1) * i + 1);
            }

        }

    }
    static void snow(ref string[,] mass)
    {
        for (int i  = 0; i < mass.GetLength(0); i++)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                if (i == (int)(mass.GetLength(0) / 2) || j == (int)(mass.GetLength(0) / 2) || i == j || i + j == mass.GetLength(0)-1)
                {
                    mass[i, j] = "*";

                }
                else
                {
                    mass[i, j] = " ";
                }
            }
        }
    }
    static int max_elem_from_zone(int[,] mass)
    {
        int res = int.MinValue;
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                if (i < j && i + j < mass.GetLength(0) - 1) { if (mass[i, j] > res) res = mass[i, j]; }
                else if (i > j && i + j > mass.GetLength(0) - 1) { if (mass[i, j] > res) res = mass[i, j]; }
            }
        }
        return res;

    }
    public static void Main()
    {
        string[,] mass = new string[4, 4];
        snake(ref mass);
        output_mass(mass);
        Console.WriteLine("Введите длину снежинки");
        int n = int.Parse(Console.ReadLine());
        string[,] mass1 = new string[n, n];
        snow(ref mass1);
        output_mass(mass1);
        int[,] mass2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine(max_elem_from_zone(mass2));
        
    }
}
