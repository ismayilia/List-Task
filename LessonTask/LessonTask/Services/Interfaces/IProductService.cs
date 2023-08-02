using LessonTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTask.Services.Interfaces
{
    internal interface IProductService
    {
        List<Product> GetAll();
        
        void SearchByName(string text);

    }
}
