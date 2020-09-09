using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double promedio;
            double primeraNota;
            double segundaNota;
            float terceraNota ;

            Console.Write("NOTA 1: ");
            primeraNota = Convert.ToDouble(Console.ReadLine());
            Console.Write("NOTA 2: ");
            segundaNota = double.Parse(Console.ReadLine());
            Console.Write("NOTA 3: ");
            terceraNota = float.Parse(Console.ReadLine());

            promedio = (primeraNota + segundaNota + terceraNota) / 3 ;

            Console.WriteLine("Promedio: {0}", promedio);

            if (promedio>= 3.0){
                Console.WriteLine("FELICITACIONES APROBASTE LA MATERIA");
            }
            else{
                Console.WriteLine("MATERIA REPROBADA");
            }
            Console.ReadKey();
        }
    }
}
