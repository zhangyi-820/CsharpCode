using System;


namespace CsharpWeekThree
{
    abstract class Shape
    {
        private double Area;
        public abstract double GetArea();
        public abstract bool IsLeagal();
        public abstract string GetInfo();
    }

    class Rectangle:Shape
    {
        
        private int width, length;
        private double area;

        public Rectangle(int width=0,int length=0)
        {
            this.length = length;
            this.width = width;
            if (this.IsLeagal())
                area = length*width;
            else
            {
                area = 0;
                Console.WriteLine("长方形边长有误");
            }
        }

        public override double GetArea()
        {
            return area;
        }

        public override string GetInfo()
        {
            return "长方形" + " 长：" + length + " 宽：" + width + "面积：" + area;
        }

        public override bool IsLeagal()
        {
            if (length > 0 && width > 0)
            {
                return true;
            }
            return false;
            
        }
    }

    class Square : Rectangle
    {
        private int length;
        private double area;

        public Square(int length=0):base(length,length)
        {
            this.length = length;
            if (this.IsLeagal())
                area = length * length;
            else
            {
                area = 0;
                Console.WriteLine("正方形边长有误");
            }
        }

        public new double GetArea()
        {
            return area;
        }

        public new string GetInfo()
        {
            return "正方形" + " 边长：" + length + "面积：" + area;
        }
    }

    class Triangle : Shape//三角形类 继承自Shape类
    {
        private int length1, length2, length3;

        private double area;

        public Triangle(int length1=0,int length2=0,int length3=0)
        {
            this.length1 = length1;
            this.length2 = length2;
            this.length3 = length3;
            if (this.IsLeagal())
            {
                double p = (length1 + length2 + length3) / 2;
                this.area = Math.Sqrt(p * (p - length1) * (p - length2) * (p - length3));
            }
            else
            {
                this.area = 0;
                Console.WriteLine("三边长不构成三角形");

            }
        }

        public override double GetArea()
        {
            return area;
        }

        public override string GetInfo()
        {
            return "三角形" + " 三边长分别为：" +length1+","+length2+","+length3 + "面积：" + area;
        }

        public override bool IsLeagal()
        {
            if (length1 + length2 <= length3 || length2 + length3 <= length1
               || length1 + length3 <= length2)
            {
                return false;
            }
            if (length1 <= 0 || length2 <= 0 || length3 <= 0)
            {
                return false;
            }
            return true;
        }
    }

    class  ShapeFactory
    {
        public static Shape CreatShape(string shape)//创建图形
        {
            Shape s = null;
            Random rd = new Random();
            bool tag=false;
            switch (shape)//根据输入的形状创建图形并且作为返回值
            {
                case "rectangle":
                    while (!tag)//当创建合法时赋值
                    {
                        int length = rd.Next() % 20, width = rd.Next() % 20;
                        s = new Rectangle(length, width);
                        tag = s.IsLeagal();
                    }
                    break;
                case "square":
                    while (!tag)
                    {
                        int squareLength = rd.Next() % 20;
                        s = new Square(squareLength);
                        tag = s.IsLeagal();
                    }
                    break;
                case "triangle":
                    while (!tag)
                    {
                        int length1 = rd.Next() % 20, length2 = rd.Next() % 20, length3 = rd.Next() % 20;
                        s = new Triangle(length1,length2,length3);
                        tag = s.IsLeagal();
                    }
                    break;
                default:
                    Console.WriteLine("名称有误");
                    break;
            }
            return s;
        }
    }

    static class test
    {
        private static double sumOfShape;//定义面积之和

        public static void Calculate()//计算面积之和
        {
            string[] MyShape = { "rectangle", "square", "triangle" };

            Shape[] test = new Shape[10];
            Random rd = new Random();
            for (int i = 0; i < 10; i++)//创建10个图形并且获取其面积
            {
                int index = rd.Next() % 3;
                test[i] = ShapeFactory.CreatShape(MyShape[index]);//根据工厂创建图形
                sumOfShape += test[i].GetArea();
            }
        }
        public static double GetSumOfShape()//返回面积之和
        {
            return sumOfShape;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rectangle = new Rectangle(1,2);
            //Console.WriteLine(rectangle.GetArea());
            //Console.WriteLine(rectangle.IsLeagal());

            //Square square = new Square();
            //Console.WriteLine(square.GetArea());
            //Console.WriteLine(square.IsLeagal());

            //Triangle triangle = new Triangle(3,4,5);
            //Console.WriteLine(triangle.GetArea());
            //Console.WriteLine(triangle.IsLeagal());

            //Shape shape = ShapeFactory.CreatShape("triangle");
            //Console.WriteLine(shape.GetArea());

            test.Calculate();
            Console.WriteLine(test.GetSumOfShape());
        }
    }
}
