using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTrain
{
    public partial class Form1 : Form
    {
        public float Number1 = 0;
        public float Number2 = 0;
        public float Res = 0.0f;
        public Form1()
        {
            InitializeComponent();
        }

        private void PrintRes_Click(object sender, EventArgs e)
        {
            if(float.TryParse(Sum1.Text, out Number1) == false)
            {
                MessageBox.Show("Sum1입력란에 숫자를 입력해주세요.");
                Sum1.SelectAll();
                Sum1.Focus();
                return;
            }
            if (float.TryParse(Sum2.Text, out Number2) == false)
            {
                MessageBox.Show("Sum2입력란에 숫자를 입력해주세요.");
                Sum2.SelectAll();
                Sum2.Focus();
                return;
            }
            Number1 = float.Parse(Sum1.Text);
            Number2 = float.Parse(Sum2.Text);
          
                Add(Number1, Number2);
           

            ResSum.Text = Res.ToString();
        }
         

        public float Add(float Number1, float Number2)
        {

            Res = Number1 + Number2;
            return Res;
        }


    }
}
