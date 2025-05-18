using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homeworke3
{
    internal class ShowingArea
    {
        ArrayList PointList;
        int height, width;
        Graphics grc;

        public ShowingArea(Graphics grc, Panel showingPNL)
        {
            this.grc = grc;
            height = showingPNL.Height;
            width = showingPNL.Width;
        }
        
        public void add (Point p)
        {
            PointList.Add(p);
        }

        public void reDrawAll()
        {
            int x, y;
            int diameter = 2;
            Brush brush = new SolidBrush(Color.Red);
            foreach (Point p in PointList)
            {
                x = (width / 2) + (p.x * (width / 20));
                y = (height/ 2) - (p.y * (height/ 20));

                x -= diameter/2;
                y -= diameter/2;
                grc.FillEllipse(brush, x, y, diameter, diameter);
            }
        }

    }
}
