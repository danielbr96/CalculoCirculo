using System;

namespace CalculoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
           double radio, diametro, perimetro;
		   
		   radio=45;
		   
		   diametro=radio*2;
		   
		   perimetro= 3.1416*diametro;
		   
			Console.WriteLine("El perimetro es: "+ perimetro);
			
            //radii circulo
             int r=10;
            //diametro de un circulo
            double diametro= (r × r)
            Console.WriteLine(diametro);
=======
        // area de un circulo
        int area = 8;
        //radio de un circulo
        double radio = Math.Sqrt(area/Math.PI);
        Console.Write(radio);
>>>>>>> Heiner
        }
    }
}
