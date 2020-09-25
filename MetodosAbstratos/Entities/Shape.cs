using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Cor { get; set; }

        protected Shape(Color color)
        {
            Cor = color;
        }

        public abstract double Area();
    }
}
