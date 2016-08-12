using System;

class Program
{
    char[] a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    static void Main()
    {
        int loop = 0;
        int position = 0;
        int letter = 65;

        while(loop<26)
        {
            if(loop < position)
            {
                Console.Write((char)(position+65));
            }
            else
            {
                Console.Write((char)(letter + loop));
            }

            loop++;

            if(loop == 26 && position < 25)
            {
                loop = 0;
                position++;
                letter = 65;
                Console.WriteLine();
            }
        }
    }
}