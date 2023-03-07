using ExeMetodosAbstratos.Entities.Enums;
using System;

namespace ExeMetodosAbstratos.Entities
{
    class Circle : Shape 
    {
        public double Radius { get; set; }  

        public Circle(double radius, Color color) : base(color)
        {
            Color = color;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius; // CALCULO DE RAIO. Math.PI * Raio * Raio (raio ao quadrado)
        }

    }
}
