using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        static int GetPrecedence(char op)
        {
            if (op == '+' || op == '-') return 1;
            if (op == '*' || op == '/') return 2;
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text;
            string postFix = "";
            input = input.Trim();
            input = input.Replace(" ", "");

            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                {
                    postFix += c;
                }else if (c == '(')
                {
                    stack.Push(c);
                }else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postFix += stack.Pop();
                    }
                    stack.Pop();
                }else
                {
                    while (stack.Count > 0 && GetPrecedence(stack.Peek()) >= GetPrecedence(c))
                    {
                        postFix += stack.Pop();
                    }
                    stack.Push(c);
                }
            }
            while (stack.Count > 0)
            {
                postFix += stack.Pop();
            }
            resultText.Text = postFix;
        }
    }
}
