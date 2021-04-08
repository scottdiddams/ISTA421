using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ASPQuiz10.Models
{
    public class Person
    {

        [Required(ErrorMessage = "Please enter your name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please enter your spouse's name, or enter 'none'")]
        public string spouseName { get; set; }
        [Required(ErrorMessage = "Please enter your oldest dog's name, or enter 'none'")]
        public string dogName { get; set; }
        [Required(ErrorMessage = "Please enter your oldest cat's name, or enter 'none'")]
        public string catName { get; set; }
    }
}
