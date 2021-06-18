using System;

namespace Correto
{
    public class Quadrado: Paralelogramo
    {
        public Quadrado(int altura, int largura): base (altura, largura)
        {
            if(largura!=altura)
                throw new ArgumentException("os dois lados devem ser iguais");
        }
    }
}