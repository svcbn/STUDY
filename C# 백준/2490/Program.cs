char[] result = {'D', 'C', 'B', 'A', 'E'};
for (int i = 0; i < 3; i++)
{
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int sum = 0;
    foreach (int n in a)
    {
        sum += n;
    }
    Console.WriteLine(result[sum]);
}