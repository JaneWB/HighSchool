using System;
using System.Linq;
using System.Collections.Generic;

namespace HighSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> S = new List<Student>()
            {
                new Student(){LastNameOfStudent = "Brown", FirstNameOfStudent = "Jane",
                CurrentGpa = 4, Grade = 12}, 
                new Student(){LastNameOfStudent = "Blue", FirstNameOfStudent = "Greg",
                    CurrentGpa = 2, Grade = 11},
                new Student(){LastNameOfStudent = "William", FirstNameOfStudent = "Erik",
                    CurrentGpa = 4, Grade = 5},
                new Student(){LastNameOfStudent = "James", FirstNameOfStudent = "Steve",
                    CurrentGpa = 4, Grade = 2},
                new Student(){LastNameOfStudent = "Color", FirstNameOfStudent = "Courtney",
                    CurrentGpa = 4, Grade = 10},
                new Student(){LastNameOfStudent = "Krump", FirstNameOfStudent = "Luke",
                    CurrentGpa = 2, Grade = 10},
                new Student(){LastNameOfStudent = "Jacob", FirstNameOfStudent = "Llew",
                    CurrentGpa = 4, Grade = 1},
                new Student(){LastNameOfStudent = "Krass", FirstNameOfStudent = "Lydia",
                    CurrentGpa = 4, Grade = 9},
                new Student(){LastNameOfStudent = "Pops", FirstNameOfStudent = "Jacob",
                    CurrentGpa = 4, Grade = 2},
                new Student(){LastNameOfStudent = "Lovely", FirstNameOfStudent = "Sue",
                    CurrentGpa = 3, Grade = 12},
            };

            var studentList = S.Where(p => p.Grade >= 9 && p.CurrentGpa >= 3).OrderByDescending(p => p.Grade).ThenByDescending(p => p.CurrentGpa).
                ThenBy(p => p.LastNameOfStudent).ThenBy(p => p.FirstNameOfStudent); 
            //OrderByDescending(p => p.LastNameOfStudent);
            //studentList = studentList

            foreach (var item in studentList)
            {
                
                Console.WriteLine("{0}, {1}  GPA: {2} Grade: {3}", item.LastNameOfStudent, item.FirstNameOfStudent, 
                    item.CurrentGpa, item.Grade);

            }
            Console.ReadLine();

        }
    }
}
