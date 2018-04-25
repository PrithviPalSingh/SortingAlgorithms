using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// Smallest convex set containing all the points
    /// Sequence of vertices in counter clockwise direction
    /// Fact 1. Can traverse a convex hull by making only counter clockwise turns
    /// Fact 2. The vertices of convex hull appears in increasing order of polar angle with respect to point "P" with lowest y-coordinate.
    /// GRAHAM SCAN ALGORITHM
    /// </summary>
    class ConvexHull
    {
        public void FindHull(Point2D[] p)
        {
            Stack<Point2D> hull = new Stack<Point2D>();
            Array.Sort(p, Point2D.Y_ORDER);// By Y-Order
            Array.Sort(p, p[0].POLAR_ORDER);// By Polar Order

            hull.Push(p[0]);
            hull.Push(p[1]);

            for (int i = 2; i < p.Length; i++)
            {
                Point2D top = hull.Pop();
                while (Point2D.CCW(hull.Peek(), top, p[i]) <= 0)
                {
                    top = hull.Pop();
                }

                hull.Push(top);
                hull.Push(p[i]);
            }
        }
    }
}
