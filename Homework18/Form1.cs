using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework18
{
    public partial class Form1 : Form
    {
        Ratio A, B, result;

        private void plusBtn_Click(object sender, EventArgs e)
        {
            result = A + B;

            resultTextSet();
            OP_Lable.Text = "+";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            result = A - B;

            resultTextSet();
            OP_Lable.Text = "-";
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            result = A * B;

            resultTextSet();
            OP_Lable.Text = "*";
        }

        private void dividBtn_Click_1(object sender, EventArgs e)
        {
            result = A / B;

            resultTextSet();
            OP_Lable.Text= "/";
        }

        private void BATB_TextChanged(object sender, EventArgs e)
        {
            comparison();
        }

        private void AATB_TextChanged(object sender, EventArgs e)
        {
            comparison();
        }

        private void ABTB_TextChanged(object sender, EventArgs e)
        {
            comparison();
        }

        private void BBTB_TextChanged(object sender, EventArgs e)
        {
            comparison();
        }

        private void initialization()
        {
            if(A == null)
                A = new Ratio();
            if(B == null) 
                B = new Ratio();
            
            A.A = int.Parse(AATB.Text);
            A.B = int.Parse(ABTB.Text);
            B.A = int.Parse(BATB.Text);
            B.B = int.Parse(BBTB.Text);

            resultRatio.Visible = ResultTextA.Visible = ResultTextB.Visible = equalLable.Visible = false;
        }

        private void comparison()
        {
            initialization();
            if (A == B)
            {
                OP_Lable.Text = "=";
            }else if(A >  B)
            {
                OP_Lable.Text = ">";
            }else
            {
                OP_Lable.Text = "<";
            }
        }

        private void resultTextSet()
        {
            ResultTextA.Text = result.A.ToString();
            ResultTextB.Text = result.B.ToString();

            resultRatio.Visible = ResultTextA.Visible = ResultTextB.Visible = equalLable.Visible = true;
        }

        public Form1()
        {
            InitializeComponent();
            comparison();  
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
