using ExeMetodosAbstratos.Entities.Enums;

// CLASSE GENERICA 
// CLASSE ABSTRATA - Não pode ser instanciada
namespace ExeMetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); // Metodo abstrato. Não precisa colocar o Virtual para implementar em outra classe. Ele sendo abstrato é obrigado a ser implementado em outra classe


    }
}
