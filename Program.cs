using System;

namespace CalculoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
        // area de un circulo
        int area = 8;
        //radio de un circulo
        double radio = Math.Sqrt(area/Math.PI);
        Console.Write(radio);
        }
    }
}
