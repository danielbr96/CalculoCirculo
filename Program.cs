using System;

namespace CalculoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
           double radio, diametro, perimetro;
		   
		   radio=45;
		   
		   diametro=radio*2;
		   
		   perimetro= 3.1416*diametro;
		   
			Console.WriteLine("El perimetro es: "+ perimetro);
			
        }
    }
}
