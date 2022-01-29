using System;

namespace ExercicioFor_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int SomaIn = 0;
            int SomaOut = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if(x >= 10 && x<= 20)
                {
                    SomaIn =SomaIn+1 ;
                    
                }
                else
                {
                    SomaOut =SomaOut+1;
                   
                }
               
            }
            Console.WriteLine(SomaIn + " in");
            Console.WriteLine(SomaOut + " Out");

        }
    }
}
