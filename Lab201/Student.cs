//phong 570611022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        //properties
        private string name = "John Doe";
        private string student_id = "Unknow";
        private int year_of_birth = 20;
        private bool isActive = true;


        //function (Methods)
        public Student()
        {
            year_of_birth = 20;
            isActive = false;
        }
        public Student(string name, string student_id)
        {

            this.name = name;
            this.student_id = student_id;

        }
        public Student(string name, string student_id, int year_of_birth)
        {
            this.name = name;
            this.student_id = student_id;
            this.year_of_birth = 2015-year_of_birth;

        }
        public Student(string name, string student_id, int year_of_birth, bool status)
        {
            this.name = name;
            this.student_id = student_id;
            this.year_of_birth = 2015-year_of_birth;
            this.isActive = status;

        }

        //because not return
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {

            return "";


        }

        public void setStudent_id(string student_id)
        {
            this.student_id = student_id;

        }
        public string getStudent_id()
        {

            return "";
        }
        public void setYearOfBirth(int year_of_birth)
        {
            if (year_of_birth <= 1950 || year_of_birth >= 2000)
            {
                Console.WriteLine(student_id+":error try setting invalid year-of-birth value!");
            }
            else
            { this.year_of_birth = 2015 - year_of_birth; }
        }
        public int getYear_of_birth()
        {

            return 0;

        }

        public void setisActive(bool status)
        {
            isActive = status;

        }
        public bool getActive()
        {


            return true;

        }
        public override string ToString()
        {
            if (isActive == true)
            {
                return name + " (" + student_id + ") " + "age=" + year_of_birth + " is active student";
            }
            else
            {
                return name + " (" + student_id + ") " + "age=" + year_of_birth + " is not active student";
            }


        }


    }

}
