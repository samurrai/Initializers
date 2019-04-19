using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializers
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new DataContext())
            {
                context.Students.Add(new Student {
                    FullName = "Danil Polov",
                    AverageMark = 4
                });
                context.SaveChanges();
                var result = context.Students.ToList();
            }
        }
    }
}
