using System;
using static System.Console;
class PaintintDemo
{
    static void Main()
    {
        // Write your main here
        Room room1 = new Room(8, 8, 8);
        Room room2 = new Room(18, 13, 10);
        Room room3 = new Room(22, 15, 11);
        
        Write(room1.Length + " " + room1.Width + " " + room1.Height);
        Write(" " + room1.Area + " " + room1.Gallons);
        WriteLine();
        Write(room2.Length + " " + room2.Width + " " + room2.Height);
        Write(" " + room2.Area + " " + room2.Gallons);
        WriteLine();
        Write(room3.Length + " " + room3.Width + " " + room3.Height);
        Write(" " + room3.Area + " " + room3.Gallons);
    }

    public class Room
    {
        private int _length;
        private int _width;
        private int _height;
        private int _area;
        private int _gallons;

        public int Length
        {
            get { return _length; }
            set { _length = value;
                CalcArea();
                CalcGallons();
            }
        }
        public int Width
        {
            get { return _width; }
            set
            {
                _width = value;
                CalcArea();
                CalcGallons();
            }
        }
        public int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                CalcArea();
                CalcGallons();
            }
        }
        public int Area
        {
            get { return _area; }

        }
        public int Gallons
        {
            get { return _gallons; }

        }

        public Room()
        {

        }
        public Room(int len, int wid, int hgt)
        {
            _length = len;
            _width = wid;
            _height = hgt;
            CalcArea();
            CalcGallons();
            

            
        }
        private void CalcArea()
        {
            _area = (Length * Height * 2) + (Width * Height * 2);
        }
        private void CalcGallons()
        {
            _gallons = 1 + ((Area - 350) / 350);
            if (Area > 350)
            {
                ++_gallons;
            }
        }

    }
}

