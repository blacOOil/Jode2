using System;
class program
{
    static void Main(string[] arg)
    {
        char fruitS = ']';
        int cuter = 0;
        int fcounter = 0;
        Queue<int> fruitC  = new Queue<int>();
        Console.WriteLine("Input fruits :");
        while(fruitS == ']'||fruitS == 'L'||fruitS == 'M'||fruitS == 'S'){
            fruitS = char.Parse(Console.ReadLine());
            if(fruitS == 'L'){
                cuter = 1;
                fruitC.Push(1);

            }
            if(fruitS == 'M'){
                fruitC.Push(2);
                cuter = 2;

            }
            if(fruitS == 'S'){
                fruitC.Push(3);

            }
            if (cuter == 1 ){
                fruitC.Push(2);
                fruitC.Push(2);
                cuter = 2 ;
            }
            if(cuter == 2){
                fruitC.Push(3);
                fruitC.Push(3);
                fruitC.Push(3);

            }
        }
        for(int x = 0;x < fruitC.GetLength();x++){
            Console.Write("{0}",fruitC.Get(x),fruitC);
        }
        

    }
}
