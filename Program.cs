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
            var j = loop < position ? (position+65) : (letter + loop);

            Console.Write((char)j);

            if(++loop == 26 && position < 25)
            {
                loop = 0;
                letter = 65;
                position++;
                Console.WriteLine();
            }
        }
    }
}