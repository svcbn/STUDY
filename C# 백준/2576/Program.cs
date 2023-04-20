int[] n = new int[7];
for (int i = 0; i < 7; i++)
{
    int t = int.Parse(Console.ReadLine());
    n[i] = (t % 2 != 0 ? t : 101);

    // if (t % 2 != 0)
    // {
    //     n[i] = t;
    // }
    // else
    // {
    //     n[i] = 101;
    // }
}

int sum = 0;
foreach (int i in n)
{
    if (i != 101)
    {
        sum += i;
    }
}

Console.WriteLine(sum == 0 ? -1 : sum + "\n" + n.Min());

// if (sum == 0)
// {
//     Console.WriteLine("-1");
//     return;
// }
// else
// {
//     Console.WriteLine(sum + "\n" + n.Min());
// }