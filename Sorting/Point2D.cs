﻿using System;
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

        private const double xAxis = 0;
        private const double yAxis = 0;

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

        private class PolarOrder : IComparer<Point2D>
        {
            public int Compare(Point2D p1, Point2D p2)
            {
                double dx1 = p1.X - xAxis;
                double dy1 = p1.Y - yAxis;
                double dx2 = p2.X - xAxis;
                double dy2 = p2.Y - yAxis;

                if (dy1 == dy2)
                {
                    return 0;
                }
                else if (dy1 >= 0 && dy2 < 0)
                {
                    return -1;
                }
                else if (dy1 < 0 && dy2 >= 0)
                {
                    return 1;
                }

                return 0;
            }
        }
    }
}
