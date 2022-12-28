namespace FigureLibrary
{
    public class Circle : IFigure
    {
        private double _radius;
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get
            {
                return _radius; 
            }
            set
            {
                _radius = value;
            } }
        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
}