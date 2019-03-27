using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCalculator
{
    public enum Operator
    {
        Add,Sub,Multi,Div,equlas
    }

    public partial class Form1 : Form
    {
        public double result = 0;
        public bool isNewNum = true;
        public double num;
        public Operator Opt = Operator.equlas;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumButton1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SetNum(button.Text);
        }
        

        public void SetNum(string number)
        {
            if (isNewNum)
            {
                NumScreen.Text = number;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = number;
            }
            else
            {
                NumScreen.Text += number;
            }

        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            if(isNewNum == false)
            {
                num = int.Parse(NumScreen.Text);
                if (Opt == Operator.Add)
                    result += num;
                else if (Opt == Operator.Sub)
                    result -= num;
                else if (Opt == Operator.equlas)
                    result = num;

                NumScreen.Text = result.ToString();
                isNewNum = true;

            }


            Button optButton = (Button)sender;
            if (optButton.Text == "+")
            {
                Opt = Operator.Add;
            }else if (optButton.Text == "-")
            {
                Opt = Operator.Sub;
            }else if (optButton.Text == "=")
            {
                Opt = Operator.equlas;

            }
        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            result = 0;
            isNewNum = true;
            Opt = Operator.Add;

            NumScreen.Text = "0";
        }

    
    }
}
