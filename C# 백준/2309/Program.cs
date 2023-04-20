int[] d = new int[9];
for (int i = 0; i < 9; i++)
{
    d[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 8; i++)
{
    int a = i;

    for (int j = 1; j < 9; j++)
    {
        int s = 0;
        int b = j;

        for (int k = 0; k < 9; k++)
        {
            if (k != a && k != b)
            {
                s += d[k];
            }
        }

        if (s == 100)
        {
            d[a] = 0;
            d[b] = 0;

            Array.Sort(d);
            for (int l = 0; l < 7; l++)
            {
                Console.WriteLine(d[l+2]);
            }
            return;
        }
    }
}