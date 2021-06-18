using System;

namespace Correto
{
    public class CalculoArea
    {
        private static void ObterAreaParalelogramo(Paralelogramo ret)
        {
            Console.Clear();
            Console.WriteLine("Calculo da area do Paralelogramo");
            Console.WriteLine();
            Console.WriteLine($"{ret.Altura} * {ret.Largura}");
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado(10, 5);
            var ret = new Retangulo(10, 5);

            ObterAreaParalelogramo(quad);
            ObterAreaParalelogramo(ret);
        }
    }
}