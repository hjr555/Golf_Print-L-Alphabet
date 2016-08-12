using System;

class Program{
    static void Main(){
        int x,y,z=65;x=y=0;
        while(x<26){
            var j=x<y?(y+65):(z+x);
            Console.Write((char)j);
            if(++x==26&&y<25){x=0;z=65;y++;Console.WriteLine();}
}}}