using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class ConvexHull
    {
        public void FindHull(Point2D[] p)
        {
            Stack<Point2D> hull = new Stack<Point2D>();
            Array.Sort(p);// By Y-Order
            Array.Sort(p);// By Polar Order

            hull.Push(p[0]);
            hull.Push(p[1]);

            for (int i = 0; i < p.Length; i++)
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
