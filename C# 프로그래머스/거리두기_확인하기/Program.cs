using System;

namespace 거리두기_확인하기
{
    class Program
    {
        const int Max = 100000;
        string[] dat = new string[Max];
        int pos = 0;

        public bool solution(string s)
        {
            s = Console.ReadLine();
            bool answer = true;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == Convert.ToChar("("))
                {
                    Push("(");
                }
                else if (s[i] == Convert.ToChar(")"))
                {
                    if (pos == 0)
                    {
                        answer = false;
                        return answer;
                    }
                    else
                    {
                        Pop();
                    }
                }
            }

            answer = Empty();
            return answer;
        }

        void Push(string s)
        {
            dat[pos++] = s;
        }

        void Pop()
        {
            pos--;
        }

        int Size()
        {
            return pos;
        }

        bool Empty()
        {
            if (pos == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
