using System;


namespace _1252
{
    public class ex3
    {



        static void Main(string[] args)
        {
            string inputBinaryNumbers = Console.ReadLine();
            string[] inputBinaryNumbersSlice = inputBinaryNumbers.Split();

            string[] binaryNumbers = new string[2] { inputBinaryNumbersSlice[0], inputBinaryNumbersSlice[1] };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < binaryNumbers[i].Length - 1; j++)
                {
                    if (binaryNumbers[i][j] == '0')
                    {
                        binaryNumbers[i] = binaryNumbers[i].Substring(1);
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            int carry = 0;
            string binaryNumbersSum = "";
            int lengthMaxNumber = -1;
            int lengthMinNumber = -1;

            if (binaryNumbers[0].Length > binaryNumbers[1].Length)
            {
                lengthMaxNumber = 0;
                lengthMinNumber = 1;
            }
            else
            {
                lengthMaxNumber = 1;
                lengthMinNumber = 0;
            }


            for (int i = 0; i < binaryNumbers[lengthMaxNumber].Length + carry; i++)
            {
                if (i < binaryNumbers[lengthMinNumber].Length)
                {
                    int partSum = 0;
                    partSum += carry;
                    carry = 0;
                    if (binaryNumbers[0][binaryNumbers[0].Length - 1 - i] == '1')
                    {
                        partSum++;
                    }
                    if (binaryNumbers[1][binaryNumbers[1].Length - 1 - i] == '1')
                    {
                        partSum++;
                    }
                    if (partSum >= 2)
                    {
                        partSum -= 2;
                        carry++;
                    }
                    if (partSum == 0)
                    {
                        binaryNumbersSum += "0";
                    }
                    else
                    {
                        binaryNumbersSum += "1";
                    }
                }
                else if (i < binaryNumbers[lengthMaxNumber].Length)
                {
                    int partSum = 0;
                    partSum += carry;
                    carry = 0;
                    if (binaryNumbers[lengthMaxNumber][binaryNumbers[lengthMaxNumber].Length - 1 - i] == '1')
                    {
                        partSum++;
                    }
                    if (partSum >= 2)
                    {
                        partSum -= 2;
                        carry++;
                    }
                    if (partSum == 0)
                    {
                        binaryNumbersSum += "0";
                    }
                    else
                    {
                        binaryNumbersSum += "1";
                    }

                }
                else
                {
                    binaryNumbersSum += "1";
                }
            }

            char[] sumArr = binaryNumbersSum.ToCharArray();
            Array.Reverse(sumArr);
            Console.WriteLine(new string(sumArr));

        }
    }
}