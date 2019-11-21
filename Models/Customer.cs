﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVCLancashire.Models
{
    public class Customer
    {

        public string Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage ="long string")]
        [DisplayName("Enter Your Name")]
        public string Name { get; set; } 
        public string Telephone { get; set; }
    }

}