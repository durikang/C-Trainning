using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float res = 0.0f;
        float number1=0;
        float number2=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void SumNumbers_Click(object sender, EventArgs e)
        {
            
            if (float.TryParse(Sum1.Text, out number1)==false)
            {
                if (string.IsNullOrWhiteSpace(Sum1.Text))
                {
                    MessageBox.Show("Sum1에 숫자를 입력해주세요.");
                    return;

                }
                else
                {
                    MessageBox.Show("Sum1에 문자가 들어왔습니다.");
                    return;

                }
            }
            if (float.TryParse(Sum2.Text, out number2) == false)
            {
                if (string.IsNullOrWhiteSpace(Sum2.Text))
                {
                    MessageBox.Show("Sum2에 숫자를 입력해주세요.");
                    return;
                }
                else
                {
                    MessageBox.Show("Sum2에 문자가 들어왔습니다.");
                    return;

                }
            }
            

            number1 = float.Parse(Sum1.Text);
            number2 = float.Parse(Sum2.Text);

            Add(number1, number2);
            SumResult.Text = res.ToString();

        }

        public float Add(float number1,float number2)
        {
            number1 = float.Parse(Sum1.Text);
            number2 = float.Parse(Sum2.Text);

            res = number1 + number2;

            return res;
        }


    }
}
