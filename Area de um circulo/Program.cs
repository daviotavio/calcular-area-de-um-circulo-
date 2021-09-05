using System;

namespace Area_de_um_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int raio;

            Console.Write("Digite o raio: ");
            raio = int.Parse(Console.ReadLine());

            Console.Write("a área é: " + Math.PI * raio * raio);

            Console.ReadKey();
        }
    }
}
