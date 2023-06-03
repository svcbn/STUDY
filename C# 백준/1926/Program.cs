using System.Collections;

int n, m;
int[,] board = new int[500, 500];
int[,] visit = new int[500, 500];
int[] dx = { -1, 1, 0, 0 };
int[] dy = { 0, 0, -1, 1 };
Queue<(int, int)> que = new Queue<(int, int)>();
int count = 0;
int max = 0;

int[] testCase = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
n = testCase[0];
m = testCase[1];

for (int i = 0; i < n; i++)
{
    int[] tempArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    for (int j = 0; j < m; j++) board[j, i] = tempArr[j];
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (board[i, j] == 0 || visit[i, j] == 1) continue;

        count++;
        visit[i, j] = 1;
        BFS(i, j, board);
    }
}

Console.WriteLine(count + "\n" + max);

void BFS(int x, int y, int[,] Arr)
{
    int _max = 0;
    que.Enqueue((x, y));
    while (que.Count != 0)
    {
        _max++;
        (int a, int b) = que.Dequeue();
        for (int i = 0; i < 4; i++)
        {
            int _x = a + dx[i];
            int _y = b + dy[i];

            if ((0 <= _x && _x < m) && (0 <= _y && _y < n) && board[_x, _y] == 1 && visit[_x, _y] == 0)
            {
                visit[_x, _y] = 1;
                que.Enqueue((_x, _y));
            }
        }
    }
    if (_max > max) max = _max;
}