int n, m;
char[,] board = new char[100, 100];
int[,] visit = new int[100, 100];
int[] dx = { -1, 1, 0, 0 };
int[] dy = { 0, 0, -1, 1 };
Queue<(int, int)> que = new Queue<(int, int)>();

int[] testCase = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
n = testCase[0];
m = testCase[1];

for (int i = 0; i < n; i++)
{
    string temp = Console.ReadLine();
    for (int j = 0; j < m; j++)
    {
        board[i, j] = temp[j];
    }
}

visit[0, 0] = 1;
BFS(0, 0, board);

Console.WriteLine(visit[n - 1, m - 1]);

void BFS(int x, int y, char[,] arr)
{
    que.Enqueue((x, y));
    while (que.Count != 0)
    {
        (int a, int b) = que.Dequeue();
        for (int i = 0; i < 4; i++)
        {
            int _x = a + dx[i];
            int _y = b + dy[i];

            if (_x < 0 || n <= _x || _y < 0 || m <= _y) continue;
            if (board[_x, _y] == '0' || visit[_x, _y] > 0) continue;

            visit[_x, _y] = visit[a, b] + 1;
            que.Enqueue((_x, _y));
        }
    }
}