using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
        class Course
        {
            private string Name;
            private string CourseID;
            private string Lecturer = "Staff";
            private int MaxStudents = 30;
            private int NumStudents;

            //constructor
            public Course()
            {
                MaxStudents = 30;
            }

            public Course(string Name, string CourseID)
            {
                this.Name = Name;
                this.CourseID = CourseID;
            }

            public Course(string Name, string CourseID, string Lecturer)
            {
                this.Name = Name;
                this.CourseID = CourseID;
                this.Lecturer = Lecturer;
                MaxStudents = 30;
            }

            public Course(string Name, string CourseID, string Lecturer, int MaxStudents)
            {
                this.Name = Name;
                this.CourseID = CourseID;
                this.Lecturer = Lecturer;
                this.MaxStudents = MaxStudents;
            }
            
            //function method
            public string getName()
            {
                return Name;
            }
            public void setName(string Name)
            {
                this.Name = Name;
            }


            public string getCouseID()
            {
                return CourseID;
            }
            public void setCourseID(string CourseID)
            {
                int number;

                bool check = int.TryParse(CourseID, out number);
                if (CourseID.Length > 6 || check == false)
                {
                    Console.WriteLine("261200: error try setting invalid CourseID!");
                }
                else
                {
                    this.CourseID = CourseID;
                }
            }

            
            public string getLecturer()
            {
                return Lecturer;
            }
            public void setLecturer(string Lecturer)
            {
                this.Lecturer = Lecturer;
            }


            public int getMaxStudents()
            {
                return MaxStudents;
            }
            public void setMaxStudents(int MaxStudents)
            {
                if ((MaxStudents >= 0 && MaxStudents <= 80)||(MaxStudents >= NumStudents))
                {
                    this.MaxStudents = MaxStudents;
                }
                else
                {
                    Console.WriteLine("261200: error try setting invalid Max No. Students!");
                }
            }


            public int getNumStudents()
            {
                return NumStudents;
            }
            public void setNumStudents(int NumStudents)
            {
                if ((NumStudents > MaxStudents)||(NumStudents < 0))
                {
                    Console.WriteLine("261200: error try setting invalid No. Students!");
                }
                else
                {
                    this.NumStudents = NumStudents;
                }
            }


            public override string ToString()
            {
                return "[Course: " + Name + " (" + CourseID + "), " + "Lecturer= " + Lecturer + ", " + "has " + NumStudents + " students," + " max=" + MaxStudents + "]";
            }
        }
}
