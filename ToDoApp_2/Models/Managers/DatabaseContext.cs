using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoApp_2.Models.Managers
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Users> Kisiler { get; set; }
        public DbSet<Tasks> Gorevler { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new VeritabaniOlusturucu());
        }
    }

    public class VeritabaniOlusturucu : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
           for(int i = 0; i < 15; i++)
            {
                Users user = new Users();
                user.Name = FakeData.NameData.GetFirstName();
                user.Surname = FakeData.NameData.GetSurname();
                user.Username = FakeData.NameData.GetFullName();
                user.Eposta = FakeData.NameData.GetFirstName() + "@gmail.com";
                user.Password = FakeData.NumberData.GetNumber()+FakeData.NameData.GetFirstName();

                context.Kisiler.Add(user);
            }

            context.SaveChanges();
            List<Users> tumKisiler = context.Kisiler.ToList();

            foreach(Users user in tumKisiler)
            {
                for (int i = 0; i < FakeData.NumberData.GetNumber(1, 7); i++)
                {
                    Tasks task = new Tasks();
                    task.Task = "insert";
                    task.UserID = user.ID;
                    context.Gorevler.Add(task);
                } 
            }

            context.SaveChanges();
        }
    }
}