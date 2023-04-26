int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = n - i; j > 1; j--)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < 2 * i + 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}