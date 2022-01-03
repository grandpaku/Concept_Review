class App
{
    static void Main()
    {
        char figure;
        char state = 'y';
        Console.WriteLine("Hello, I can calculate the Area of several geometric figures");
        while (state.IgnoreCase() == 'y')
        {
            Console.WriteLine("What figure do you wish to calculate. C = circle, T = triangle, R = rectangle");
            figure = Convert.ToChar(Console.ReadLine);
            if (figure.IgnoreCase() == 'c')
            {
                double radius;
                Console.WriteLine("Circle Selected");
                Console.WriteLine("Please provide the radius: ");
                radius = Convert.ToDouble(Console.ReadLine());
                Shape circle = new Circle(radius);
                Console.WriteLine("The area is equal to {0}", circle.CalculateArea());
            }
            else if (figure.IgnoreCase() == 't')
            {
                double tside1, tside2, tside3;
                Console.WriteLine("Triangle Selected\nPlease provide side one: ");
                tside1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please provide side two: ");
                tside2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please provide side three: ");
                tside3 = Convert.ToDouble(Console.ReadLine());
                Shape triangle = new Triangle(tside1, tside2, tside3);
                Console.WriteLine("The area is equal to {0}", triangle.CalculateArea());
            }
            else if (figure.IgnoreCase() == 'r')
            {
                double side1, side2;
                Console.WriteLine("Rectangle Selected\nPlease provide side one: ");
                side1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please provide side two: ");
                side2 = Convert.ToDouble(Console.ReadLine());
                Shape rectangle = new Rectangle(side1, side2);
                Console.WriteLine("The area is equal to {0}", rectangle.CalculateArea());
            }
            Console.WriteLine("Would you like to make another calculation? y/n");
            state = Convert.ToChar(Console.ReadLine());
        }
    }
}

abstract class Shape
{
    public abstract double CalculateArea();
}

class Square : Shape 
{
    private double side1;
    private double side2;
    public Square() {}
    public Square(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    public override double CalculateArea()
    {
        double area = this.side1 * this.side2;
        return area;
    }
}

class Triangle : Shape 
{
    private double tside1;
    private double tside2;
    private double tside3;
    public Triangle() {}
    public Triangle(double tside1, double tside2, double tside3)
    {
        this.tside1 = tside1;
        this.tside2 = tside2;
        this.tside3 = tside3;
    }
    public override double CalculateArea()
    {
        double s = Convert.ToDouble((this.tside1+this.tside2+this.tside3)/2);
        double area = Convert.ToDouble(Math.Sqrt(s*(s-this.tside1)*(s-this.tside2)*(s-this.tside3)));
        return area;
    }
}

class Circle : Shape 
{
    private double radius;
    public Circle() {}
    public Circle(double r)
    {
        this.radius = r;
    }
    public override double CalculateArea()
    {
        double area = (double)(Math.Pow(this.radius, 2) * Math.PI);
        return area;
    }
}