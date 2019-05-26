using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Full_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            EFContext context = new EFContext();

            Course course = context.Courses.Find(1);
            context.Courses.Remove(course);
            
            context.SaveChanges();


            Console.WriteLine("done.");
            Console.ReadKey();
        } 
    }
}
