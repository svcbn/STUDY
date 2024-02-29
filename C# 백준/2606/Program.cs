int[,] map = new int[101, 101];
int[] visit = new int[101];
Queue<int> que = new Queue<int>();
int count = 0;

int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
for (int i = 0; i < m; i++)
{
    int[] t = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    map[t[0], t[1]] = 1;
    map[t[1], t[0]] = 1;
}

visit[1] = 1;
que.Enqueue(1);
BFS();
Console.Write(count - 1);

void BFS()
{
    while (que.Count != 0)
    {
        int x = que.Dequeue();
        count++;

        for (int i = 1; i <= n; i++)
        {
            if (map[x, i] != 1 || visit[i] != 0) continue;
            visit[i] = 1;
            que.Enqueue(i);
        }
    }
}