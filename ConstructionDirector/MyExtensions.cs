using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionDirector
{
    public static class MyExtensions
    {
        public static Point GetLocationRelativeTo(this Control thisControl, Control control)
        {
            Point location = new(0,0);
            Control temp = thisControl;
            while (temp != control && temp != null)
            {
                location = location.Add(temp.Location);
                temp = temp.Parent;
            }
            if (temp == null)
            {
                temp = control;
                while (temp != null)
                {
                    location = location.Subtract(temp.Location);
                    temp = temp.Parent;
                }
            }
            return location;
        }
        public static Point Add(this Point thisPoint, Point point)
        {
            return new(thisPoint.X + point.X, thisPoint.Y + point.Y);
        }
        public static Point Subtract(this Point thisPoint, Point point)
        {
            return new(thisPoint.X - point.X, thisPoint.Y - point.Y);
        }

    }
}
