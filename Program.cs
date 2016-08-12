using System;

class Program
{
    static void Main()
    {
        int loop = 0;
        int position = 0;
        int letter = 65;

        while(loop<26)
        {
            var x = loop < position ? (position+65) : (letter + loop);

            Console.Write((char)x);

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