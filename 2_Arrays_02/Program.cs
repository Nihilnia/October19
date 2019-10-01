using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Arrays_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much student do you want to insert?: ");
            int userChoice = int.Parse(Console.ReadLine());

            string[] studentName = new string[userChoice];
            int[] studentNumber = new int[userChoice];

            for (int i = 0; i < userChoice; i++)
            {
                Console.WriteLine($"\n{i + 1}.Student name: ");
                string name = Console.ReadLine();
                studentName[i] = name;

                Console.WriteLine($"{i + 1}.Student's number: ");
                int number = int.Parse(Console.ReadLine());
                studentNumber[i] = number;
            }

            Console.WriteLine("Insert process is done, here is the list of students!");

            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine($"Student name: {studentName[i]}, number: {studentNumber[i]}");
            }

            Console.ReadKey();

        }
    }
}
