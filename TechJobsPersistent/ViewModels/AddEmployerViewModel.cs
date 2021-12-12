﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Employer Name is required.")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Employer location is required.")]


        public string Location { get; set; }

    }
}
