using System;

namespace CodrFirstStudentChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Dave" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            Console.WriteLine("Student entry made.");
            Console.ReadLine();
        }
    }
}
