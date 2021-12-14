using SampleApp.Models;
using System;
using System.Linq;

namespace SampleApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.UserDetails.Any()){return;}
            var Users = new ForUser[]
            {
            new ForUser{UserName="sa",Password="sa"}           
            };
            foreach (ForUser u in Users)
            {
                context.UserDetails.Add(u);
            }
            context.SaveChanges();

           
        }
    }
}
