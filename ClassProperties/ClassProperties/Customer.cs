using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        // private int _Age;
        private DateTime _Birthday;
        private bool _IsQualified;
       
        public string Address;
        public string Description;


        public Customer(string firstname, string lastname, DateTime Birthday)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this._Birthday = Birthday;

            this._IsQualified = Age >= 18;

        }
        /// //////////////////////////////////////
        /// ////////아래 내용////
        ///  메서드를 이용한 private의 접근
        /// //////////////////////////////////////
       /* public int GetAge()
        {
            return _Age;
        }
        public void SetAge(int age)
        {
            _Age = age;
            _IsQualified = age >= 18;
        }
        //
        public bool GetIsQualified()
        {
            return _IsQualified;
        }
        */
        /// //////////////////////////////////////
        /// ////////////////위 내용///////////////////
        ///   메서드를 이용한 private의 접근
        ///   //////////////////////////////////////

        public DateTime Birthday{
            get { return _Birthday; }
            set { _Birthday = value;
                
              _IsQualified = Age >= 18;
            }


            }


        public int Age//속성을 이용한 private _Age의 접근
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
            

        }
      

       public bool IsQualified//속성을 이용한 private _IsQualified의 접근
        {
            get { return _IsQualified; }//get만 있을경우 _IsQualified는 보호됨. 읽기 전용
            //set{ _IsQualified = value;}
        }

       public string GetFullName()
        {
            return LastName + " " + FirstName;
        }

        public string FullName
        {
            get { return LastName + " " + FirstName; }
        }

      
    }
}
