using System;
using System.Collections.Generic;
using System.Text;

namespace LB5_Number1.SquareSolution
{
    class Point
    {
        public Point() { }
        public Point(double X, double Y, double Length)
        {
            this.X = X+311d;
            this.Y = -Y+240d;
            this.Length = Length;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Length { get; set; }

        public Point Left
        {
            get
            {
                Point LeftPoint = new Point();
                LeftPoint.X = X-10d;
                LeftPoint.Y = Y;
                LeftPoint.Length = Length;
                return LeftPoint;
            }
        }
        public Point Right
        {
            get
            {
                Point RightPoint = new Point();
                RightPoint.X = X+10d;
                RightPoint.Y = Y;
                RightPoint.Length = Length;
                return RightPoint;
            }
        }
        public Point UP
        {
            get
            {
                Point UpPoint = new Point();
                UpPoint.X = X;
                UpPoint.Y = Y-10d;
                UpPoint.Length = Length;
                return UpPoint;
            }
        }
        public Point Down
        {
            get
            {
                Point DownPoint = new Point();
                DownPoint.X = X;
                DownPoint.Y = Y+10d;
                DownPoint.Length = Length;
                return DownPoint;
            }
        }
    }
}
