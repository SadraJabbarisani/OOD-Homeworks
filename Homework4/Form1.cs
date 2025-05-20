using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4
{
    public partial class Form1 : Form
    {
        Ratio A, B, result;

        private void plusBtn_Click(object sender, EventArgs e)
        {
            A = new Ratio();
            A.A = int.Parse(AATB.Text);
            A.B = int.Parse(ABTB.Text);

            B = new Ratio();
            B.A = int.Parse(BATB.Text);
            B.B = int.Parse(BBTB.Text);

            result = A.add(B);

            ResultTextA.Text = result.A.ToString();
            ResultTextB.Text = result.B.ToString();
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            A = new Ratio();
            A.A = int.Parse(AATB.Text);
            A.B = int.Parse(ABTB.Text);

            B = new Ratio();
            B.A = int.Parse(BATB.Text);
            B.B = int.Parse(BBTB.Text);

            Ratio helpRatio = new Ratio();
            helpRatio.A = -1;
            helpRatio.B = 1;

            B = B.Mul(helpRatio);

            result = A.add(B);

            ResultTextA.Text = result.A.ToString();
            ResultTextB.Text = result.B.ToString();
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            A = new Ratio();
            A.A = int.Parse(AATB.Text);
            A.B = int.Parse(ABTB.Text);

            B = new Ratio();
            B.A = int.Parse(BATB.Text);
            B.B = int.Parse(BBTB.Text);

            result = A.Mul(B);

            ResultTextA.Text = result.A.ToString();
            ResultTextB.Text = result.B.ToString();
        }

        private void dividBtn_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
