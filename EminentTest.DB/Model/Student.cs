using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EminentTest.DB.Model
{
    public class Student
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string  FirstName { get; set; }


        [Required]
        public string LastName { get; set; }


        [Required]
        public int Gender { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(100,ErrorMessage ="Comment too long..100 max")]
        public string Comment { get; set; }


    }
}
