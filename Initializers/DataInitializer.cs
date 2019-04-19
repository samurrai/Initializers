using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Initializers
{
    public class DataInitializer : DropCreateDatabaseAlways<DataContext>
    {
        private List<Student> students;

        public DataInitializer()
        {
            students = new List<Student> {
                new Student
                {
                    FullName = "Ivan Pavlov",
                    AverageMark = 9.3
                },
                new Student
                {
                    FullName = "Petr Dnishenko",
                    AverageMark = 6.9
                },
                new Student
                {
                    FullName = "Ruslan Shadikyan",
                    AverageMark = 11.9
                }
            };
        }

        protected override void Seed(DataContext context)
        {
            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
