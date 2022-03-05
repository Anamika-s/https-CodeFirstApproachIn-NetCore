using CodeFirstApproachDemo.EntityContext;
using CodeFirstApproachDemo.Models;
using System;
using System.Linq;

namespace CodeFirstApproachDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // CRUD operations
            // LINQ 
            // SqlConnection conn = new     ()
            // SqlCommand comm = new SqlCOmmand("Select * from empl"
            // insert int Emp ()
            // One Language > LINQ
            // We can use it with any data source which implements
            // IEnumerable / IQueryable interface

            StudentDbContext db = new StudentDbContext();
            var listOfStudents = db.Students.ToList();
            //var listOfStudents = (from temp in db.Students
            //                      select temp);
            if (listOfStudents.Count == 0)
                Console.WriteLine("No Records");
            else
                foreach (Student student in db.Students)
                    Console.WriteLine(student.Id + " " + student.Name);
            // C > Create 
            Student student1 = new Student()
            {
                Name = "Deepak",
                //Batch = "B001",
                Marks = 90
            };

            db.Students.Add(student1);
            db.SaveChanges();
            // R > Update
            // Give me records whose id is 2
            //var student2 = (from temp in db.Students
            //                    where temp.Id == 2
            //                    select temp);
            var student2 = db.Students.FirstOrDefault(x => x.Id == 2);
            if(student2 != null)
                Console.WriteLine(student2.Name);
            else
                Console.WriteLine("No studnet with this ID");

            // U > Update Record
            var student3 = db.Students.FirstOrDefault(x => x.Id == 2);
            if (student3 != null)
            {
                Console.WriteLine(student3.Name);
                foreach(Student temp in db.Students)
                {
                    if(temp.Id== 2)
                    {
                        //temp.Batch = "New Batch";
                        temp.Marks = 90;
                    }
                    
                }
                db.SaveChanges();
                
            }
            else
                Console.WriteLine("No studnet with this ID");

        

        // D > Delete Record
        var student4 = db.Students.FirstOrDefault(x => x.Id == 2);
            if (student4 != null)
            {
                Console.WriteLine(student4.Name);
                db.Students.Remove(student4);
                db.SaveChanges();  
                
            }
            else
                Console.WriteLine("No studnet with this ID");

        }
    }
}