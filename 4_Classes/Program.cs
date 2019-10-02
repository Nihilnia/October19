using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Classes
{
    class Program
    {
        class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Number { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How much student do you wanna create?: ");
            var userChoice = int.Parse(Console.ReadLine());

            Student[] studentsList = new Student[userChoice];

            for (int i = 0; i < userChoice; i++)
            {
                Console.WriteLine($"\n{i + 1}. Student name: ");
                var studentName = (Console.ReadLine());

                Console.WriteLine("Student Number: ");
                var studentNumber = int.Parse(Console.ReadLine());

                Student newStudent = new Student() {
                    ID = i + 1,
                    Name = studentName,
                    Number = studentNumber
                };

                studentsList[i] = newStudent;
            }

            Console.WriteLine("All students:\n");
            for (int i = 0; i < studentsList.Length; i++)
            {
                Console.WriteLine($"{studentsList[i].ID}\n{studentsList[i].Name}\n{studentsList[i].Number}\n\n\n");
            }

            Console.Read();
        }
    }
}
