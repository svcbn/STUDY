using System.Collections;

int[,] board = new int[50, 50];
int[,] visit = new int[50, 50];
int m, n, k;
int count = 0;

int[] dx = { -1, 1, 0, 0 };
int[] dy = { 0, 0, -1, 1 };
Queue<(int, int)> que = new Queue<(int, int)>();

int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    int[] testCase = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    m = testCase[0];
    n = testCase[1];
    k = testCase[2];

    for (int j = 0; j < k; j++)
    {
        int[] tempArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        board[tempArr[0], tempArr[1]] = 1;
    }

    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            if (board[x, y] == 0 || visit[x, y] == 1) continue;

            count++;
            visit[x, y] = 1;
            BFS(x, y, board);
        }
    }

    Console.WriteLine(count);

    count = 0;
    for (int a = 0; a < 50; a++)
    {
        for (int b = 0; b < 50; b++)
        {
            board[a, b] = 0;
            visit[a, b] = 0;
        }
    }
}


void BFS(int i, int j, int[,] arr)
{
    que.Enqueue((i, j));
    while (que.Count != 0)
    {
        (int a, int b) = que.Dequeue();
        for (int k = 0; k < 4; k++)
        {
            int x = a + dx[k];
            int y = b + dy[k];

            if ((0 <= x && x < m) && (0 <= y && y < n) && board[x, y] == 1 && visit[x, y] == 0)
            {
                visit[x, y] = 1;
                que.Enqueue((x, y));
            }
        }
    }
}