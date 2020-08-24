using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Drop_tut.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public Gender StudentGender { get; set; }
    }

    public enum Gender
    {
        Male,
        Famale
    }


}