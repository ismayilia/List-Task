using LessonTask.Models;
using LessonTask.Services;
using LessonTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LessonTask.Controllers
{
    internal class AccountController
    {
        private readonly IAccountService _accountService;
        private readonly IProductService _productService;

        public AccountController()
        {
            _accountService = new AccountService();
            _productService = new ProducService();
        }

        public void Login()
        {
            Console.WriteLine("Add email: ");
            A:  string name = Console.ReadLine();

            Console.WriteLine("Add password: ");
            string password = Console.ReadLine();

            bool login = _accountService.Login(name, password);
            if (login)
            {
                Console.WriteLine(" Choose: 1 or 2");
                N:  string choose = Console.ReadLine();

                int num1;

                bool isTry=int.TryParse(choose, out num1);

                if (isTry)
                {
                    switch (num1)
                    {
                        case 1:
                        var products = _productService.GetAll();
                            foreach (var product in products)
                            {
                                string result = $"{product.Id} - {product.Name} - {product.Price} - {product.Count}";
                                Console.WriteLine(result);
                            }
                        break;
                        case 2:
                            Console.WriteLine("Add search text: ");
                            string text = Console.ReadLine();

                            
                             _productService.SearchByName(text);

                            break;
                        default:
                            Console.WriteLine("Please select again:");
                            goto N;

                    }
                    
                }

                

            }
            else
            {
                Console.WriteLine("Email or password is wrong, please try again");
                goto A;
            }


        }
        






    }
}
