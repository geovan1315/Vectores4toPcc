using System;

namespace Vectores4toPcc
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dato =new int[3];// 0,1,2

            string line;

            /*
            dato[0] = 55;
            dato[1] = 1;
            dato[2] = 22;
            */

            for (int i=0; i<3;i++)
            {
                Console.Write("ingrese un valor: ");
                line = Console.ReadLine();
                dato[i] = int.Parse(line);
            }

            for (int x=0;x<3;x++)
            {
                Console.WriteLine("el dato del vector en la posicion "+x+" es: " + dato[x]);
            }
        }
    }
}
