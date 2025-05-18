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
        Point addingPoint;

        public Form1()
        {
            InitializeComponent();
            EmptyError.Visible = false;
            showingArea = new ShowingArea(graph);
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

                addingPoint = new Point();
                addingPoint.x = int.Parse(xTextBox.Text);
                addingPoint.y = int.Parse(yTextBox.Text);

                showingArea.add(addingPoint);
            }
        }
    }
}
