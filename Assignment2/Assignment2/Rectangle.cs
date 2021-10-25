using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Rectangle
    {
        private int len;
        private int wid;
        private int hgt;

        public Rectangle()
        {
            this.len = 1;
            this.wid = 1;
            this.hgt = 1;
        }
        public Rectangle(int value1,int value2,int value3)
        {
            this.len = value1;
            this.wid = value2;
            this.hgt = value3;
        }

        public int GetLength()
        {

            return this.len;
        }

        public void SetLength(int length)
        {
            this.len = length;
            Console.WriteLine("length set to " + length);
        }

        public int GetWidth()
        {

            return this.wid;
        }

        public void SetWidth(int width)
        {
            this.wid = width;
            Console.WriteLine("width set to " + width);
        }
        public int GetHeight()
        {

            return this.hgt;
        }

        public void SetHeight(int height)
        {
            this.hgt = height;
            Console.WriteLine("height set to " + height);
        }

        public double GetVolume()
        {
            double volume = (this.len * this.wid * this.hgt);
            Console.WriteLine("Volume is ");
            return volume;
        }
}
}
