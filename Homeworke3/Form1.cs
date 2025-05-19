using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homeworke3
{
    public partial class Form1 : Form
    {
        ShowingArea showingArea;
        Point p1, p2;

        public Form1()
        {
            InitializeComponent();
            EmptyError.Visible = false;
            showingArea = new ShowingArea(graph);
            p1 = p2 = null;
        }

        

        private void addBTN_Click(object sender, EventArgs e)
        {
            if (xTextBox.Text.Length == 0 || yTextBox.Text.Length == 0)
            {
                EmptyError.Visible = true;
                return;
            }
            else
            {
                if (p1 == null)
                {
                    showingArea.clear();

                    p1 = new Point();
                    p1.x = int.Parse(xTextBox.Text);
                    p1.y = int.Parse(yTextBox.Text);

                    showingArea.add(p1);
                }
                else
                {
                    p2 = new Point();
                    p2.x = int.Parse(xTextBox.Text);
                    p2.y = int.Parse(yTextBox.Text);

                    showingArea.add(p2);

                    p1 = p2 = null ;
                }
                
            }
        }
    }
}
