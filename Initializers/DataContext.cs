namespace Initializers
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {       
        public DataContext()
            : base("name=DataContext")
        {
            Database.SetInitializer(new DataInitializer()); // наш класс, наследующийся от класса в System.Data.Entity
            //Database.SetInitializer(new DropCreateDatabaseAlways<DataContext>()); // 
        }

        public DbSet<Student> Students { get; set; }
    }
}