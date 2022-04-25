namespace Area_Calc_Zundel
{
    
    public class AreaCalculator
    {
        static readonly Dictionary<string, int> basicNumsDictionary = new Dictionary<string, int>
        {
            {"one",1 },
            {"two",2},
            {"three",3 },
            {"four",4 },
            {"five",5},
            {"six",6 },
            {"seven",7 },
            {"eight",8 },
            {"nine",9 },
            {"ten",10 }

        };
        public double getSquareArea(int sideLength)
        {
            double Area = sideLength * sideLength;

            return Area;
        }
        public double getSquareArea(string sideLength)
        {
            sideLength = sideLength.ToLower();
            double Area = getSquareArea(basicNumsDictionary.TryGetValue(sideLength, out int x )? x : 0);

            return Area;
        }
        public double getRectangleArea(int sideLength, int sideWidth)
        {
            double Area = sideWidth*sideLength;
            return Area;
        }
        public double getTriangleArea(int baseLength, int height)
        {
            double Area = getRectangleArea(baseLength,height)/2;
            return Area;
        }
        public double getParallelogramArea(int baseLength, int height)
        {
            double Area = getRectangleArea(baseLength, height);
            return Area;
        }
        public double getCircleRadius(int circumference)
        {
            double radius = circumference / (2*3.14);
            radius = Math.Round(radius, 2);
            return radius;
        }
        public double CircleDiameter(int radius)
        {
            double diameter = radius *2;

            return diameter;
        }

    }
}