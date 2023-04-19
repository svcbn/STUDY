using System;

namespace _10809
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = Console.ReadLine();

            for (int i = 0; i < 26; i++)
            {
                Console.Write((q.IndexOf(Convert.ToChar(i+97))) + " ");
            }
            
        }
    }
}
