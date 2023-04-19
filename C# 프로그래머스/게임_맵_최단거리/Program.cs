using System.Collections.Generic;
using System;

class Solution
{
    int answer = 0;

    public int solution(int[,] maps)
    {
        BFS(0, 0, 5, 5, maps);
        return answer;
    }

    void BFS(int y, int x, int targetY, int targetX, int[,] maps)
    {
        int[,] direction = new int[,]
        {
                {-1, 0},
                {1, 0},
                {0, -1},
                {0, 1},
        };
        bool[,] checkRoad = null;

        ClearCheckRoad(checkRoad, maps);
        BFSNode bestNode = null;

        Queue<BFSNode> queue = new Queue<BFSNode>();
        queue.Enqueue(new BFSNode(y, x, null));
        checkRoad[y, x] = true;

        while (queue.Count > 0)
        {
            BFSNode node = queue.Dequeue();

            if (node.Y == targetY && node.X == targetX)
            {
                if (bestNode == null || bestNode.PrevCount > node.PrevCount)
                {
                    bestNode = node;
                }
            }

            for (int i = 0; i < direction.GetLength(0); i++)
            {
                int dy = node.Y + direction[i, 0];
                int dx = node.X + direction[i, 1];

                if (CheckMapRange(dy, dx, maps) && CheckMapWay(dy, dx, maps) && !checkRoad[dy, dx])
                {
                    BFSNode searchNode = new BFSNode(dy, dx, node);
                    queue.Enqueue(searchNode);

                    checkRoad[dy, dx] = true;
                }
            }
        }

        answer = bestNode.PrevCount;
    }

    bool CheckMapRange(int y, int x, int[,] maps)
    {
        return y >= 0 && y < maps.GetLength(0) && x >= 0 && x < maps.GetLength(1);
    }

    bool CheckMapWay(int y, int x, int[,] maps)
    {
        return maps[y, x] == 1;
    }


    void ClearCheckRoad(bool[,] checkRoad, int[,] maps)
    {
        checkRoad = new bool[maps.GetLength(0), maps.GetLength(1)];
        for (int i = 0; i < checkRoad.GetLength(0); i++)
        {
            for (int j = 0; i < checkRoad.GetLength(1); i++)
            {
                checkRoad[i, j] = false;
            }
        }
    }   
}


public class BFSNode
{
    public int X{ get; private set; }
    public int Y{ get; private set; }
    public BFSNode PrevNode { get; private set; }
    public int PrevCount{ get; private set; }

    public BFSNode(int y, int x, BFSNode prevNode)
    {
        Y = y;
        X = x;
        PrevNode = prevNode;
        
        if(prevNode == null)
        {
            PrevCount = 0;
        }
        else
        {
            PrevCount = prevNode.PrevCount + 1;
        }
    }
}