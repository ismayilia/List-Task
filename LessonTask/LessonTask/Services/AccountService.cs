using LessonTask.Models;
using LessonTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask.Services
{
    internal class AccountService : IAccountService
    {
        public bool Login(string email, string password)
        {
            
            
                List<User> list = new()
            {
                new User {Email="i.afendi@yahoo.com", Password="salam123"},
                new User { Email = "ismayil@mail.com", Password = "salam123" },
                new User { Email = "xeyyam@mail.com", Password = "salam123" }
            };

            var result = list.FirstOrDefault(m => m.Email == email && m.Password == password);

            if (result != null)
            {
                return true;
            }
            return false;
        }


           
        
    }
       
    
}
