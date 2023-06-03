int r, c;
char[,] board = new char[1000, 1000];
int[,] jVisit = new int[1000, 1000];
int[,] fVisit = new int[1000, 1000];
int[] dx = { -1, 1, 0, 0 };
int[] dy = { 0, 0, -1, 1 };
Queue<(int, int)> jQue = new Queue<(int, int)>();
Queue<(int, int)> fQue = new Queue<(int, int)>();

int[] testCase = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
r = testCase[0];
c = testCase[1];

for (int i = 0; i < r; i++)
{
    string temp = Console.ReadLine();
    for (int j = 0; j < c; j++)
    {
        board[i, j] = temp[j];
        jVisit[i, j] = -1;
        fVisit[i, j] = -1;
    }
}

for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {

        if (board[i, j] == 'F')
        {
            fVisit[i, j] = 0;
            fQue.Enqueue((i, j));
        }
        if (board[i, j] == 'J')
        {
            jVisit[i, j] = 0;
            jQue.Enqueue((i, j));
        }
    }
}

FireBFS();

JihoonBFS();


void FireBFS()
{
    while (fQue.Count != 0)
    {
        (int a, int b) = fQue.Dequeue();
        for (int i = 0; i < 4; i++)
        {
            int _x = a + dx[i];
            int _y = b + dy[i];

            if (_x < 0 || _y < 0 || r <= _x || c <= _y) continue;
            if (board[_x, _y] == '#' || fVisit[_x, _y] >= 0) continue;

            fVisit[_x, _y] = fVisit[a, b] + 1;
            fQue.Enqueue((_x, _y));
        }
    }
}

void JihoonBFS()
{
    while (jQue.Count != 0)
    {
        (int a, int b) = jQue.Dequeue();
        for (int i = 0; i < 4; i++)
        {
            int _x = a + dx[i];
            int _y = b + dy[i];

            if (_x < 0 || _y < 0 || r <= _x || c <= _y)
            {
                Console.Write(jVisit[a, b] + 1);
                return;
            }

            if (board[_x, _y] == '#' || jVisit[_x, _y] >= 0) continue;
            if (fVisit[_x, _y] != -1 && jVisit[a, b] + 1 >= fVisit[_x, _y]) continue;

            jVisit[_x, _y] = jVisit[a, b] + 1;
            jQue.Enqueue((_x, _y));
        }
    }
    Console.Write("IMPOSSIBLE");
}