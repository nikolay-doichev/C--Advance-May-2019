namespace _02._Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StratUp
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = 
                new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var entry = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //Ivancho 5.20

                string nameOfStudent = entry[0];
                double gradeOfStudent = double.Parse(entry[1]);

                if (students.ContainsKey(nameOfStudent))
                {
                    students[nameOfStudent].Add(gradeOfStudent);
                }
                else
                {
                    students[nameOfStudent] = new List<double>()
                    {
                        gradeOfStudent
                    };
                }

            }

            foreach (var item in students)
            {
                //Console.WriteLine($"{item.Key} -> {string.Join(' ',item.Value)} (avg: {item.Value.Average():F2})");
                var studentName = item.Key;
                var grades = item.Value;
                var avaregaeGrades = grades.Average();

                Console.Write($"{studentName} -> ");

                foreach (var grade in grades)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {avaregaeGrades:F2})");
            }
        }
    }
}
