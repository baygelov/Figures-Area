namespace Area
{
    public class Triangle : Shape
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }

        public double GetPerimeter() => (sideA + sideB + sideC) / 2;
        public double GetArea()
        {
            double Perimeter = GetPerimeter();
            return Math.Sqrt(Perimeter * (Perimeter - sideA) * (Perimeter - sideB) * (Perimeter - sideC));
        }

        public bool isosceles() => (sideA == sideB) ? true : false;
    }
}