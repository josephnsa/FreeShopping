﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FreeShopping.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage = "The Filed (0) must containt less than (1) characteres. ")]
        [Required]
        public string  Name { get; set; }
        public ICollection<Department> Departments { get; set; }

        [DisplayName("Departments Number")]
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;

    }
}
