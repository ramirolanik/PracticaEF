using ClassLibrary1.Data;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Logic
{
    public class CategoriesLogic
    {
        private readonly Model2 context;

        public CategoriesLogic()
        {
            context = new Model2();

        }

        public List<Categories> GetAll()
        {

            return context.Categories.ToList();

        }


    }
}
