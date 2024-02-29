int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[,] a = new int[1001, 1001];
int[] visit = new int[1001];
Queue<int> que = new Queue<int>();
int c = 0;

for (int i = 0; i < n[1]; i++)
{
    int[] t = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    a[t[0], t[1]] = 1;
    a[t[1], t[0]] = 1;
}


for (int i = 1; i <= n[0]; i++)
{
    if (visit[i] != 0) continue;
    c++;
    visit[i] = 1;
    que.Enqueue(i);

    while (que.Count != 0)
    {
        int x = que.Dequeue();

        for (int j = 1; j <= n[0]; j++)
        {
            if (a[x, j] != 1 || visit[j] != 0) continue;
            que.Enqueue(j);
            visit[j] = 1;
        }
    }
}

Console.Write(c);