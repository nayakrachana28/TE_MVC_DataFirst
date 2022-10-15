using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TE_MVC_DataFirst.Models
{
    public partial class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage ="Name is Requried")]
        public string? StudentName { get; set; }

        [Required(ErrorMessage ="Age is Requried")]
        [Range(21,35,ErrorMessage ="The age is not valide, It showed be between 21 to 35")]
        public int? StudentAge { get; set; }
    }
}
