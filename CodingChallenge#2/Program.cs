using System;

public class CountNum
{
    public static void Main()
    {
        string strcount;
        int s, wordcount;

        Console.WriteLine("Coding Challenge No. 2\n");
        Console.Write("Input String:");
        strcount = Console.ReadLine();

        s = 0;
        wordcount = 1;

        while (s <= strcount.Length - 1)
        {
            if (strcount[s] == ' ' || strcount[s] == '\n' || strcount[s] == '\t');
            {
                wordcount++;
            }

            s++;
        }
;
        Console.Write("Total number of strings:{0}\n Converted Uppercase String: {1}", wordcount, strcount.ToUpper());
    }

}
