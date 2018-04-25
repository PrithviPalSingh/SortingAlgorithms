using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Point2D
    {
        private double X;
        private double Y;

        private const double xAxis = 0;
        private const double yAxis = 0;

        public IComparer<Point2D> POLAR_ORDER = new PolarOrder();
        public static IComparer<Point2D> Y_ORDER = new YOrder();

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static int CCW(Point2D a, Point2D b, Point2D c)
        {
            double area = (b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X);

            if (area < 0) // Clockwise
            {
                return -1;
            }
            else if (area > 0) // Counter clockwise
            {
                return 1;
            }
            else
            {
                return 0; // Collinear
            }
        }

        private class PolarOrder : IComparer<Point2D>
        {
            public int Compare(Point2D p1, Point2D p2)
            {
                double dx1 = p1.X - xAxis;
                double dy1 = p1.Y - yAxis;
                double dx2 = p2.X - xAxis;
                double dy2 = p2.Y - yAxis;

                if (dy1 == 0 && dy2 == 0)
                {
                    return 0;
                }
                else if (dy1 >= 0 && dy2 < 0)
                {
                    return -1;
                }
                else if (dy2 >= 0 && dy1 < 0)
                {
                    return 1;
                }
                else
                {
                    return -CCW(new Point2D(xAxis, yAxis), p1, p2);
                }
            }
        }

        private class YOrder : IComparer<Point2D>
        {
            public int Compare(Point2D p1, Point2D p2)
            {
                if (p1.Y - p2.Y > 0)
                {
                    return 1;
                }
                else if (p1.Y - p2.Y < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
