using System.Collections;

int n, m, max = 0;
int[,] board = new int[1000, 1000];
int[,] visit = new int[1000, 1000];
int[] dx = { -1, 1, 0, 0 };
int[] dy = { 0, 0, -1, 1 };

Queue<(int, int)> que = new Queue<(int, int)>();

int[] testCase = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
n = testCase[1];
m = testCase[0];

for (int i = 0; i < n; i++)
{
    int[] tempArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++) board[i, j] = tempArr[j];
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (board[i, j] == 1) que.Enqueue((i, j));
        if (board[i, j] == 0) visit[i, j] = -1;
    }
}

BFS();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (visit[i, j] == -1)
        {
            Console.Write("-1");
            return;
        }
        max = Math.Max(max, visit[i, j]);
    }
}
Console.Write(max);

void BFS()
{
    while (que.Count != 0)
    {
        (int a, int b) = que.Dequeue();
        for (int i = 0; i < 4; i++)
        {
            int _x = a + dx[i];
            int _y = b + dy[i];

            if (_x < 0 || _y < 0 || n <= _x || m <= _y) continue;
            if (board[_x, _y] != 0 || visit[_x, _y] > 0) continue;

            visit[_x, _y] = visit[a, b] + 1;
            que.Enqueue((_x, _y));
        }
    }
}