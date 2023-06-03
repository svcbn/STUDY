int n, k;
int[] visit = new int[100002];
Queue<int> que = new Queue<int>();

int[] testCase = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
n = testCase[0];
k = testCase[1];

for (int i = 0; i < visit.Length; i++) visit[i] = -1;

visit[n] = 0;
que.Enqueue(n);
BFS();
Console.Write(visit[k]);

void BFS()
{
    while (que.Count != 0)
    {
        int a = que.Dequeue();
        int _y = 0;

        for (int i = 0; i < 3; i++)
        {
            if (i == 0) _y = a - 1;
            else if (i == 1) _y = a + 1;
            else _y = a * 2;

            if (_y < 0 || 100000 < _y) continue;
            if (visit[_y] != -1) continue;

            visit[_y] = visit[a] + 1;
            que.Enqueue(_y);
        }
    }
}