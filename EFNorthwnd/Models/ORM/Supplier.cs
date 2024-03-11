﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNorthwnd.Models.ORM
{
    public class Supplier:BaseModel
    {
        public string CompanyName {  get; set; }
        [MaxLength(40)]
        public string? ContactName { get; set;}
        [MaxLength(30)]
        public string? ContactTitle { get; set; }
        [MaxLength(30)]

        public string? Address { get; set; }
        [MaxLength(60)]
        public string? City { get; set; }
        [MaxLength(15)]
        public string? Region { get; set; }
        [MaxLength(15)]
        public string? PostalCode { get; set;}
        [MaxLength(10)]
        public string? Country { get; set; }
        [MaxLength(15)]
        public string? Phone { get; set; }
        [MaxLength(24)]
        public string? Fax { get; set;}
        [MaxLength(24)]
        public string? HomePage { get; set; }



    }
}
