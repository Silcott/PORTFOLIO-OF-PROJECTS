using System;

namespace CircleCalculator
{
    public class Circle
    {
        private readonly double radius;
        private readonly double area;
        private readonly double circum;

        public Circle(double radius = 0)
        {
            this.radius = radius;
            this.area = Math.PI * radius * radius;
            this.circum = 2.0 * Math.PI * radius;
        }
        public static Circle operator +(Circle lhs, Circle rhs)
        {
            return new Circle(lhs.area + rhs.area);
        }
        public static Circle operator -(Circle lhs, Circle rhs)
        {
            return new Circle(lhs.area - rhs.area);
        }
        public static Circle operator *(Circle lhs, Circle rhs)
        {
            return new Circle(lhs.area * rhs.area);
        }
        public override string ToString()
        {
            return ($"I am a Circle. My radius is {radius}, my area is {area}, and my circumference is {circum}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C# quiz 22");
            Circle a = new Circle(3);
            Console.WriteLine(a.ToString());

            Circle b = new Circle(4);
            Console.WriteLine(b.ToString());

            Console.WriteLine("new + operator");
            Circle c = a + b;
            Console.WriteLine(c.ToString());

            Console.WriteLine("new - operator");
            c = b - a;
            Console.WriteLine(c.ToString());

            Console.WriteLine("new * operator");
            c = a * b;
            Console.WriteLine(c.ToString());
        }
    }
}


//Quiz 22 — Operator Overloading
//C# Programming
//This is a timed test. You have thirty minutes to complete the test. When you finish the test, upload your
//Program.cs to Canvas. Do not publish your answer to your git repository.
//Create a console application. Create a struct (or class if you prefer) for a Circle. Override the ToString()
//method.Overload the addition(+), subtraction(-), and multiplication(*) operators.We arbitrarily define the +
//operator as adding the area of two circles to create a new circle, the - operator as subtracting the area of two circles
//to create a new circle, and the * operator as multiplying the area of two circles to create a new circle.1
//Define a constructor that takes a double as the radius and makes a circle using the radius argument.Instantiate
//two circles. I called them a which has a radius of 4, and b which has a radius of 3. I then created a new circle c by
//adding, subtracting, and multiplying a and b. Be careful in the subtraction that you do not have a negative radius.
//Also, it may be helpful to see that you can calculate the radius r of a circle given its area a by r =
//pa
//π
//.
//Here is my Main() method:
//1 s t a t i c void Main ( st r ing [ ] a r g s )
//2 {
//    3 C on s ole . WriteLine( ” This i s C# q ui z 22 ” ) ;
//4 C i r c l e a = new C i r c l e(3) ;
//    5 C on s ole . W riteLine(a.T oS t rin g ( ) );
//    6
//7 C i r c l e b = new C i r c l e(4);
//    8 C on s ole . W riteLine(b.T oS t rin g ( ) );
//    9
//10 C on s ole . Wri teLine( ”new + o p e r a t o r ” ) ;
//    11 C i r c l e c = a + b;
//    12 C on s ole . Wri teLine(c.T oS t rin g ( ) );
//    13
//14 C on s ole . Wri teLine( ”new = o p e r a t o r ” ) ;
//    15 c = a = b;
//    16 C on s ole . Wri teLine(c.T oS t rin g ( ) );
//    17
//18 C on s ole . Wri teLine( ”new * o p e r a t o r ” ) ;
//    19 c = a * b;
//    20 C on s ole . Wri teLine(c.T oS t rin g ( ) );
//    21 }
//Here is the expected output:
//This is C# quiz 22
//I am a Circle. My radius is 3, my area is 28.274333882308138, and my circumference is 18.84955592153876
//I am a Circle. My radius is 4, my area is 50.26548245743669, and my circumference is 25.132741228718345
//new + operator
//I am a Circle.My radius is 5, my area is 78.53981633974483, and my circumference is 31.41592653589793
//new - operator
//I am a Circle.My radius is 2.6457513110645907, my area is 21.991148575128555, and my circumference is
//16.623745764132163
//new * operator
//I am a Circle.My radius is 21.269446210866192, my area is 1421.2230337568676, and my circumference is
//133.63987192396098