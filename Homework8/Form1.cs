using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalculateBTN_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            double radius, area, perimeter;
            radius = double.Parse(inputTextBox.Text);
            circle.setRadius(radius);
            
            area = circle.getArea();
            perimeter = circle.getPerimeter();

            

            areaShow.Text = area.ToString("F3");
            perimeterShow.Text = perimeter.ToString("F3");

        }
    }
}
