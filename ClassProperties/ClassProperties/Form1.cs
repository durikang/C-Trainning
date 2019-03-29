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

            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQualified);
            

            //ShowDetails(CustomerArray[CustomerArrayIndex]);


            CustomerArray.Add(cus);

            CusNewFirstName.Text = "";
            CusNewLastName.Text = "";
            CusNewAge.Text = "";
            CusNewAddress.Text = "";
            CusNewDescription.Text = "";
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

                CusPetInfo.Text = "";

                foreach(Pet pet in cus.myPets)
                {
                   
                    CusPetInfo.Text +=$"이름: {pet.Name}  음성: {pet.MakeSound()} ";

                    if (pet is Cat)
                    {
                        CusPetInfo.Text +=$"특징: {(pet as Cat).Scretch()} ";
                    }else if(pet is Dog)
                    {
                        CusPetInfo.Text += $"특징: {(pet as Dog).Bite()} ";
                    }

                    CusPetInfo.Text += Environment.NewLine;

                }

            }
        }

        
        private void CusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string FirstName =(string)CusList.Rows[e.RowIndex].Cells[0].Value;

            foreach (Customer cus in CustomerArray)
            {
                if (cus.FirstName == FirstName)
                {
                    ShowDetails(cus);
                    break;
                }

            }
            CusDetailPanel.Show();
            CusNewPanel.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CusListPanel.Dock = DockStyle.Fill;
            CusDetailPanel.Dock = DockStyle.Right;
            CusNewPanel.Dock = DockStyle.Right;

            Customer cus = new Customer("Ian", "na", new DateTime(2000, 1, 2));
            Cat cat = new Cat(1,"Lucas","white","Male");
            cus.Adopt(cat);

            Cat cat2 = new Cat(3, "Ruby", "Brown", "FeMale");
            cus.Adopt(cat);


            Dog dog = new Dog(2,"HanStar","Black","Femal",DogBreed.bulldog);
            cus.Adopt(dog);

            CustomerArray.Add(cus);
            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQualified);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CusNewPanel.Show();
            CusDetailPanel.Hide();
        }






        //DateTime date = new DateTime(2019,3,27);//날짜와 시간을 저장함. 구조체형태임

    }

    }

