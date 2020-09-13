using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace JQueryDatePicker.Models
{
    public class Customer
    {
        [Display(Name="Join Date")] 
        public string JoinDate { get; set; }
    }
}