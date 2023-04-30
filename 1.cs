using System;
 
namespace DisciplineList
{
    class Program
    {
        enum Discipline : int
        {
            BachelorDiscipline1 = 1,
            BachelorDiscipline2 = 2,
            BachelorDiscipline3 = 3,
            BachelorDiscipline4 = 4,
            MasterDiscipline1 = 5,
            MasterDiscipline2 = 6,
            MasterDiscipline3 = 7,
            MasterDiscipline4 = 8
        }
 
        static void Main(string[] args)
        {
            Console.WriteLine("Discipline List:");
 
            Console.WriteLine("{0} - {1}", (int)Discipline.BachelorDiscipline1, "Bachelor Discipline 1");
            Console.WriteLine("{0} - {1}", (int)Discipline.BachelorDiscipline2, "Bachelor Discipline 2");
            Console.WriteLine("{0} - {1}", (int)Discipline.BachelorDiscipline3, "Bachelor Discipline 3");
            Console.WriteLine("{0} - {1}", (int)Discipline.BachelorDiscipline4, "Bachelor Discipline 4");
            Console.WriteLine("{0} - {1}", (int)Discipline.MasterDiscipline1, "Master Discipline 1");
            Console.WriteLine("{0} - {1}", (int)Discipline.MasterDiscipline2, "Master Discipline 2");
            Console.WriteLine("{0} - {1}", (int)Discipline.MasterDiscipline3, "Master Discipline 3");
            Console.WriteLine("{0} - {1}", (int)Discipline.MasterDiscipline4, "Master Discipline 4");
 
            Console.Write("\nEnter discipline numbers (comma separated): ");
            string input = Console.ReadLine();
 
            string[] disciplineNumbers = input.Split(',');
            Console.WriteLine("\nSelected disciplines:");
            foreach (string number in disciplineNumbers)
            {
                int disciplineNumber = int.Parse(number);
                switch (disciplineNumber)
                {
                    case (int)Discipline.BachelorDiscipline1:
                    case (int)Discipline.BachelorDiscipline2:
                    case (int)Discipline.BachelorDiscipline3:
                    case (int)Discipline.BachelorDiscipline4:
                        Console.WriteLine("Bachelor Discipline {0}", disciplineNumber);
                        break;
                    case (int)Discipline.MasterDiscipline1:
                    case (int)Discipline.MasterDiscipline2:
                    case (int)Discipline.MasterDiscipline3:
                    case (int)Discipline.MasterDiscipline4:
                        Console.WriteLine("Master Discipline {0}", disciplineNumber - 4);
                        break;
                    default:
                        Console.WriteLine("Invalid discipline number: {0}", disciplineNumber);
                        break;
                }
            }
 
            Console.WriteLine("\nAuthor: [your name]");
            Console.WriteLine("\nBachelor Disciplines:");
            Console.WriteLine("- Bachelor Discipline 1");
            Console.WriteLine("- Bachelor Discipline 2");
            Console.WriteLine("- Bachelor Discipline 3");
            Console.WriteLine("- Bachelor Discipline 4");
 
            Console.WriteLine("\nMaster Disciplines:");
            Console.WriteLine("- Master Discipline 1");
            Console.WriteLine("- Master Discipline 2");
            Console.WriteLine("- Master Discipline 3");
            Console.WriteLine("- Master Discipline 4");
 
            Console.ReadLine();
        }
    }
}
