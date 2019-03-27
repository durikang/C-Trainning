using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCsharpWin
{
    public enum Operators { Add,Sub,Multi,Div }

    public partial class Calculator : Form
    {

        public int Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;
        public int num = 0;

        public Calculator()
        {
            InitializeComponent();

        }
      

        private void NumButton1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
          
        }
        

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
                NumScreen.Text = num;
            else
                NumScreen.Text = NumScreen.Text + num;
        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            
            if (isNewNum == false)
            {
                num = int.Parse(NumScreen.Text);//초기값 0
                switch (Opt)
                {
                    case Operators.Add:Result+=num; break;
                    case Operators.Sub: Result-=num; break;
                    case Operators.Multi: Result *= num; break;
                    case Operators.Div: Result /= num; break;

                }
                
                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }



            Button optButton = (Button)sender;

            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";

        }

        
    }
}
