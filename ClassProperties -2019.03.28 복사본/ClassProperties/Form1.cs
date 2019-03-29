using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ClassProperties
{
    public partial class Form1 : Form
    {
       public List<Customer> CustomerArray = new List<Customer>();
        DateTime birthday;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            birthday = DateTime.Parse(CusNewAge.Text);
            Customer cus= new Customer(CusNewFirstName.Text, CusNewLastName.Text, birthday);
            cus.Address = CusNewAddress.Text;
            cus.Description = CusNewDescription.Text;

            CustomerList.Items.Add(cus.FirstName);


            //ShowDetails(CustomerArray[CustomerArrayIndex]);


            CustomerArray.Add(cus);

        }

        public void ShowDetails(Customer cus)
        {
            if (cus.Age <= 0)
            {
                MessageBox.Show("현재 나이가 0살 이하일 순 없습니다.");
            }
            else
            {
                CusFullName.Text = cus.FullName;
                CusAge.Text = cus.Age.ToString();
                CusAddress.Text = cus.Address;
                CusDescription.Text = cus.Description;
                if (cus.IsQualified)
                    CusIsQualified.Text = "가능";
                else CusIsQualified.Text = "불가능";

            }



        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            string FirstName = CustomerList.SelectedItem.ToString();

            foreach(Customer cus in CustomerArray)
            {
                if (cus.FirstName == FirstName)
                {
                    ShowDetails(cus);
                    break;
                }

            }

        }

       




        //DateTime date = new DateTime(2019,3,27);//날짜와 시간을 저장함. 구조체형태임

    }

    }

