

using ExeMetodosAbstratos.Entities.Enums;

namespace ExeMetodosAbstratos.Entities
{
    class Rectangle : Shape // PRECISAMOS IMPLEMENTAR O METODO AREA PORQUE SE NÃO DA ERRO
    {
        public double Width { get; set; }   
        public double Height { get; set; }  

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
            Color = color;
        }

        public override double Area() //Sobreescrita do metodo Area que pertence a classe Shape. Override para sobrepor nessa classe o metodo Area da classe Abstrata(que nao pode ser instaciada) Shape
        {
            return Width * Height;  
        }

    }
}
