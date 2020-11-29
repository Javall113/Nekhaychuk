using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Animation;

namespace LB5_Number1.SquareSolution
{
    class Square
    {
        public Square() { }
        public Square(Point BasePoint)
        {
            this.BasePoint = BasePoint;
        }
        public Point BasePoint;
        //Получение точек
        public virtual Point GetPointA()
        {
            return BasePoint;
        }
        public virtual Point GetPointB()
        {
            Point pointB = new Point();
            pointB.X = BasePoint.X + BasePoint.Length;
            pointB.Y = BasePoint.Y;
            pointB.Length = BasePoint.Length;

            return pointB;
        }
        public virtual Point GetPointC()
        {
            Point pointC = new Point();
            pointC.X = BasePoint.X + BasePoint.Length;
            pointC.Y = BasePoint.Y + BasePoint.Length;

            return pointC;
        }
        public virtual Point GetPointD()
        {
            Point pointD = new Point();
            pointD.X = BasePoint.X;
            pointD.Y = BasePoint.Y + BasePoint.Length;

            return pointD;
        }

        //Передвижение фигуры
        public Square MoveLeft()
        {
            return new Square(BasePoint.Left);
        }
        public Square MoveRight()
        {
            return new Square(BasePoint.Right);
        }
        public Square MoveUP()
        {
            return new Square(BasePoint.UP);
        }
        public Square MoveDown()
        {
            return new Square(BasePoint.Down);
        }
    }
}
