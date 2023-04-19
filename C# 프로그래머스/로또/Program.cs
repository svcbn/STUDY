using System;

public class Solution
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        int count = 0;
        int zeros = 0;
        int rank = 6;

        for (int i = 0; i < lottos.Length; i++)
        {
            if (lottos[i] == 0)
            {
                zeros++;
                rank--;
            }
            for (int j = 0; j < lottos.Length; j++)
            {
                if (lottos[i] == win_nums[j])
                {
                    count++;
                    rank--;
                }
            }
        }
        int[] answer = new int[] {Math.Clamp(rank+1, 1, 6), Math.Clamp(rank+zeros+1, 1, 6)};
        return answer;
    }
}