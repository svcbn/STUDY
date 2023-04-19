using System;
using System.Collections;
using System.Collections.Generic;
public class ex5

{
    public static void Main()
    {
        // your code goes here

        string num = Console.ReadLine();

        string num1 = num.Split()[0];
        string num2 = num.Split()[1];

        int len1 = num1.Length;
        int len2 = num2.Length;
        int carry = 0;

        int temp1 = 0;
        int temp2 = 0;
        int temp3 = 0;

        Stack<int> res = new Stack<int>();

        while (len1 > 0 || len2 > 0)
        {
            if (len1 > 0)
                temp1 = Convert.ToInt32(num1[len1 - 1]) - 48;
            else
                temp1 = 0;

            if (len2 > 0)
                temp2 = Convert.ToInt32(num2[len2 - 1]) - 48;
            else
                temp2 = 0;

            temp3 = temp1 + temp2 + carry;

            if (temp3 == 3)
            {
                temp3 = 1;
                carry = 1;
            }
            else if (temp3 == 2)
            {
                temp3 = 0;
                carry = 1;
            }
            else
            {
                carry = 0;
            }

            res.Push(temp3);
            len1--;
            len2--;
        }
        res.Push(carry);

        while (res.Peek() == 0)
        {
            res.Pop();
            if (res.Count == 0)
                break;
        }

        if (res.Count == 0)
            Console.Write("0");
        else
            foreach (int a in res)
            {
                Console.Write(a);
            }
    }
}