using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.ViewComponents
{
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            PersonGridModel personGridModel = new PersonGridModel()
            {
                GridTitle = "Person List",
                Persons = new List<Person>(){
                new Person() { PersonName = "John", JobTitle = "Manager" },
                new Person() { PersonName = "Nehan", JobTitle = "Developer" },
                new Person() { PersonName = "Pathan", JobTitle = "ProductManager" },

                }
            };


            return View(personGridModel); //invoked a partial view Views/Shared/Components/Grid/Default.cshtml 
        }
    }
}