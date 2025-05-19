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
        ArrayList PointList ;
        int height, width;
        Graphics grc;
        Point centerPoint ;
        Panel panel ;

        public ShowingArea(Panel showingPNL)
        {
            grc = showingPNL.CreateGraphics();
            height = showingPNL.Height;
            width = showingPNL.Width;
            panel = showingPNL;

            centerPoint = new Point();
            centerPoint.x = width/2;
            centerPoint.y = height/2;

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
            Brush  brush = new SolidBrush(Color.Red);
            Brush Lbrush = new SolidBrush(Color.Black);
            Brush Tbrush = new SolidBrush(Color.Green);
            Font  Tfont  = new Font("Arial", 12);


            foreach (Point p in PointList)                        
            {
                x = (centerPoint.x + (p.x * (width / 21)));
                y = (centerPoint.y - (p.y * (height/ 21)));

                grc.DrawLine(new Pen(Lbrush),centerPoint.x , centerPoint.y , x, y);
                grc.DrawString(
                    p.distance().ToString("F2"), 
                    Tfont, Tbrush,
                    centerPoint.x + ((p.x) / 2 * (width / 21)),
                    centerPoint.y - ((p.y) / 2 * (height / 21))
                    );

                x -= diameter/2;
                y -= diameter/2;
                grc.FillEllipse(brush, x, y, diameter, diameter);
            }
            if (PointList.Count == 2){
            Point p1, p2 , pc;
            p1 = (Point)PointList[0];
            p2 = (Point)PointList[1];
            grc.DrawLine(new Pen(Lbrush),
                centerPoint.x + ((p1.x) * (width / 21)),
                centerPoint.y - ((p1.y) * (height / 21)), 
                centerPoint.x + ((p2.x) * (width / 21)),
                centerPoint.y - ((p2.y) * (height / 21))
                );
            pc = new Point();
            pc.x = (p1.x + p2.x) / 2;
            pc.y = (p1.y + p2.y) / 2;
                grc.DrawString(
                    p1.distance(p2).ToString("F2"),
                    Tfont, Tbrush,
                    centerPoint.x + ((pc.x) * (width / 21)),
                    centerPoint.y - ((pc.y) * (height / 21)));
            }
        }

        public void clear()
        {
            PointList.Clear();
            grc.DrawImage(panel.BackgroundImage,0,0);
        }

    }
}
