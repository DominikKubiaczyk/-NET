using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace demo.Domain
{
    public class UserData
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public string Country {get; set;}

        public List<SelectListItem> Countries { get; set; }
        
        public UserData(){
            Countries = new List<SelectListItem>();
            Countries.Add(new SelectListItem {Text = "Polska", Value = "1"});
            Countries.Add(new SelectListItem {Text = "Niemcy", Value = "2"});
        }
    }
}