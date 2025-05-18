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

        public ShowingArea(Panel showingPNL)
        {
            grc = showingPNL.CreateGraphics();
            height = showingPNL.Height;
            width = showingPNL.Width;
            PointList = new ArrayList();
        }
        
        public void add (Point p)
        {
            PointList.Add(p);
            reDrawAll();
        }

        private void reDrawAll()
        {
            int x, y;
            int diameter = 20;
            Brush brush = new SolidBrush(Color.Red);
            foreach (Point p in PointList)
            {
                x = (int)((width / 2) + (p.x * (width / 21)));
                y = (int)((height/ 2) - (p.y * (height/ 21)));

                x -= diameter/2;
                y -= diameter/2;
                grc.FillEllipse(brush, x, y, diameter, diameter);
            }
        }

    }
}
