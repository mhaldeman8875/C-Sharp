using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Practical_Exercise.ViewModels
{
    public class AdminVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Quote { get; set; }
    }
}