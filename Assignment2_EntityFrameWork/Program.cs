using Assignment2_EntityFrameWork.Contexts;
using Assignment2_EntityFrameWork.Entities;

namespace Assignment2_EntityFrameWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterpriceDBContext dbContext = new EnterpriceDBContext();

            #region Insert
            Student student1 = new Student()
            {
                Fname = "Eman",
                Lname = "Adel",
                Address = "10 Of Ramadan",
                Age = 23,

            };

            Student student2 = new Student()
            {
                Fname = "Amira",
                Lname = "Adel",
                Address = "Madent Badr",
                Age = 23,

            };

            dbContext.Students.Add(student1);
            dbContext.Students.Add(student2);
            Console.WriteLine(dbContext.Entry(student1).State);
            Console.WriteLine(dbContext.Entry(student2).State);

            dbContext.SaveChanges();

            Console.WriteLine(dbContext.Entry(student1).State);
            Console.WriteLine(dbContext.Entry(student2).State); 
            #endregion
        }
    }
}
