using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managment_System
{

    enum Gender
    {
        Male,
        Female,
        other
    }

    struct Marks
    {
        public int[] scors;
        public Marks(int size)
        {
            scors = new int[size];
        }
    }
    class student {

        private string id;
        private string name;
        private int age;
        private Gender gender;
        private Marks marks;
        public student(string id, string name, int age, Gender gender, Marks marks)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Marks = marks;
        }

        //using setter and getter method

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }

        }
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public Marks Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public void showInfo()
        {
            Console.WriteLine($"ID:{ID}, Name:{Name}, Age:{Age},Gender:{Gender}");
            Console.WriteLine("Marks: "+ string.Join( ", ", marks.scors));
            Console.WriteLine("-----------------------------");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[100];
            int count = 0;
            bool exit = false;

            while(!exit) {
                Console.WriteLine("===Student Managment System====");
                Console.WriteLine("1.ADD STUDENT");
                Console.WriteLine("2.DISPLAY ALL STUDENT");
                Console.WriteLine("3.FIND STUDENT WITH HIGHEST AVERAGE");
                Console.WriteLine("4.UPDATE STUDENT MARKS");
                Console.WriteLine("5.DISPLAY STUDENTS BY GENDER");
                Console.WriteLine("6.EXIT");

                Console.WriteLine("CHOOSE AND OPTION");

                string choice= Console.ReadLine();

                switch(choice) {
                    case 1:
                        Console.WriteLine("Enter Student ID:");
                        string id=Console.ReadLine();
                        Console.WriteLine("Enter Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter Age");
                        int age= int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER GENDER (MALE/FEMALE/OTHERS)");
                        Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

                        Marks marks = new Marks(5);
                        for (int i = 0; i < 5; i++)
                        {

                            Console.Write($"Enter marks for subject{i + 1}:");
                            marks.scors[i] = int.Parse(Console.ReadLine());
                        }
                        students[count++] = new Student(id,name, age, gender, marks);
                        Console.WriteLine("Student Added Successfully");
                        break;

                    case 2:
                        Console.WriteLine("All student:");
                        for(int i=0; i<count; i++)
                        {
                            students[i].showInfo();
                        }
                    case 3:





                }
            }
}
