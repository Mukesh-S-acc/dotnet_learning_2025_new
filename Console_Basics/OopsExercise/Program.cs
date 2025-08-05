using System;


class Program
{
    class Printer
    {
        public virtual void PrintMessage()
        {
            Console.WriteLine("Base class printer");
        }
    }
    class ColorPrinter: Printer
    {
        public override void PrintMessage()
        {
            base.PrintMessage();
            Console.WriteLine("Color Printer Message");
        }
    }

    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Add(double x, double y)
        {
            return x + y;
        }
        public string Add(string x, string y)
        {
            return x + y;
        }
    }

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("\nShape class drawing");
        }
    }
    class Circle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Circle class drawing");
        }
    }
    class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("\nEmployee is working");
        }
    }
    class Developer : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Developer is working");
        }
        public void WriteCode()
        {
            Console.WriteLine("Developer writes code");
        }
    }

    class Device
    {
        public virtual void Start()
        {
            Console.WriteLine("\nDevice starting");
        }
        public void Start(string mode)
        {
            Console.WriteLine("Device starting in " + mode + " mode");
        }
    }
    class SmartPhone : Device
    {
        public override void Start()
        {
            Console.WriteLine("Smartphone starting");
        }
    }




    public static void Main()
    {

        ColorPrinter cp = new ColorPrinter();
        cp.PrintMessage();

        Calculator calc = new Calculator();
        Console.WriteLine("\nAddition value : " + calc.Add(2, 3));
        Console.WriteLine("Addition value: " + calc.Add(2.5, 3.5));
        Console.WriteLine("Add value : " + calc.Add("EY ", "-GDS"));


        Shape shape = new Shape();
        shape.Draw();

        Circle circle = new Circle();
        circle.Draw();

        
        Employee emp = new Developer();
        emp.Work();                        

        Developer downcasted = (Developer)emp; 
        downcasted.WriteCode();              

        SmartPhone phone = new SmartPhone();
        Device deviceRef = phone;           
        deviceRef.Start();                  

        SmartPhone phoneRef = (SmartPhone)deviceRef;
        phoneRef.Start("Silent");



    }





}