using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Point2D
    {
        private double X;
        private double Y;

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static int CCW(Point2D a, Point2D b, Point2D c)
        {
            double area = (b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X);

            if (area < 0)
            {
                return -1;
            }
            else if (area > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
