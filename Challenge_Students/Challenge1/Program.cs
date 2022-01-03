using System;

char figure;
char state = 'y';
double Area;
//Ask for the type of figure while state is 'y'
Console.WriteLine("Hello, I can calculate the Area of several geometric figures");
while (state == 'y')
{
    Console.WriteLine("What figure do you wish to calculate. C = circle, T = triangle, R = rectangle");
    figure = Convert.ToChar(Console.ReadLine);

    //select the function according the figure selected
    if (figure.IgnoreCase() == 'c')
    {
        Area = calculateCircle();
        Console.WriteLine("The area is equal to {0}", Area);
    }
    else if (figure.IgnoreCase() == 'r')
    {
        Area = calculateRectangle();
        Console.WriteLine("The area is equal to {0}", Area);
    }
    else 
    {
        Area = calculateTriangle();
        Console.WriteLine("The area is equal to {0}", Area);
    }

    Console.WriteLine("Do you wish to continue calculating y/n");
    state = Convert.ToChar(Console.ReadLine());
}

static double calculateTriangle()
{
    double a, b, c, s, result;
    Console.WriteLine("Side a");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Side b");
    b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Side c");
    c = Convert.ToDouble(Console.ReadLine());

    s = Convert.ToDouble((a + b + c)/2);
    result = Convert.ToDouble(Math.Sqrt(s*(s-a)*(s-b)*(s-c)));
    return result;
}

static double rectangleFunction()
{
    double side1, side2, result;
    Console.WriteLine("Rectangle Selected\nPlease Provide me the variables\nWhat is your 1st side?");
    side1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What is your 2nd side?");
    side2 = Convert.ToDouble(Console.ReadLine());
    result = side1*side2;
    return result;
}

static double circleFunction()
{
    double result, radius;
    Console.WriteLine("Circle Selected\nPlease Provide me the variables\nWhat is your radius?");
    radius = Convert.ToDouble(Console.ReadLine());
    result = Math.PI*(Math.Pow(radius,2));
    return result;
}