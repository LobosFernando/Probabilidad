using System;


namespace Probabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! \n");
            
            const int total = 46;

            int[] numeros = new int[total];

            int[] sorteado = new int[6];
            
            for (int i = 0; i < total; i++)
            {
                numeros[i] = i;

            }

            var rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                //Console.WriteLine("Numero: " + numeros[i]);

                Console.WriteLine(sorteado[i]=rand.Next(46));

            }
           
            Array.Sort(sorteado);
            
            Console.Clear();

            for (int i = 0; i < 6; i++)
            {
               
                Console.WriteLine(sorteado[i]);
            }



        }
    }
}
