﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseFirst.Models
{
    public partial class SelectAllCategoriesResult
    {
        public int CategoryID { get; set; }
        [StringLength(15)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
