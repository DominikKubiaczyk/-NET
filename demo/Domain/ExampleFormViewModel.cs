using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace demo.Domain
{
    public class ExampleFormViewModel
    {
        public ExampleForm Form { get; set; }
        public List<SelectListItem> Countries { get; set; }

        public ExampleFormViewModel()
        {
            Form = new ExampleForm();
            Countries = new List<SelectListItem>();
            Countries.Add(new SelectListItem {Text = "Polska", Value = "Polska"});
            Countries.Add(new SelectListItem {Text = "Niemcy", Value = "Niemcy"});
        }
    }
}