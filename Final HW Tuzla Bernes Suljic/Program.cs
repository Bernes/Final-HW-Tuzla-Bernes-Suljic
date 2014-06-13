using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_HW_Tuzla_Bernes_Suljic
{
    class Program
    {

        public static List<Student> students = new List<Student>(); //lista objekata tipa Student

        static void Main(string[] args)
        {
            //I had to put new student under each of those so it can be written
            //under a different line each time and not all used by same Id
            //thus the program wouldn't get confused
            students.Add(new Student("Michael", "Jordan","Age:", 57));
            students.Add(new Student("Kobe", "Bryant","Age:". 36));
            students.Add(new Student("LeBron", "James","Age:", 27));


            students.Sort();
            
            //I wrote it with foreach even though
            //i could have used other ways but foreach simplfies it the most
            foreach (Student n in students)
            {
                Console.WriteLine(n.name);
            }
            Console.ReadLine();
            //has to end with console read or it wouldn't run at all.
            //it would just open and close automatically
        }
    }
}
