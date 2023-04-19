using System;

namespace _2754
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = Console.ReadLine();
            float grade = 0.0f;
            if (q.Substring(0, 1) == "A")
            {
                grade = 4.0f;
                if(q.Substring(1) == "+")
                {
                    grade += 0.3f;
                }
                else if (q.Substring(1) == "-")
                {
                    grade -= 0.3f;
                }
            }
            else if (q.Substring(0, 1) == "B")
            {
                grade = 3.0f;
                if (q.Substring(1) == "+")
                {
                    grade += 0.3f;
                }
                else if (q.Substring(1) == "-")
                {
                    grade -= 0.3f;
                }
            }
            else if (q.Substring(0, 1) == "C")
            {
                grade = 2.0f;
                if (q.Substring(1) == "+")
                {
                    grade += 0.3f;
                }
                else if (q.Substring(1) == "-")
                {
                    grade -= 0.3f;
                }
            }
            else if (q.Substring(0, 1) == "D")
            {
                grade = 1.0f;
                if (q.Substring(1) == "+")
                {
                    grade += 0.3f;
                }
                else if (q.Substring(1) == "-")
                {
                    grade -= 0.3f;
                }
            }
            
            Console.WriteLine(string.Format("{0:F1}", grade));
        }
    }
}
