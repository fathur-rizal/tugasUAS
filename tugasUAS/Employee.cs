﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tugasUAS
{
    using System;
    using System.Collections.Generic;

    public partial class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter age")]
        public Nullable<int> Age { get; set; }

        [Required(ErrorMessage = "Please enter position")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Please enter office")]
        public string Office { get; set; }

        [Required(ErrorMessage = "Please enter salary")]
        public Nullable<int> Salary { get; set; }
    }
}