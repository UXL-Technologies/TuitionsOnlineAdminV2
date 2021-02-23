//Authors: SA, BM, SM
//Date:08-Jan-2021
//Aim: defining the entity for graduate course

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
    public class GraduateCourse
    {
        //property to store gradutae course Id
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GraduateCourseId { get; set; }

        //property to store gradutae course name
        [Column(TypeName = "varchar(150)")]
        [Required(ErrorMessage = "Please enter the name of the graduate course.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        [MaxLength(150, ErrorMessage = "The graduate course name you have entered is too long. Please restrict the name to less than 150 alphabets.")]
        [RegularExpression(@"^[A-Za-z\s]{1,}[\.]{0,}[A-Za-z.\s]{0,}", ErrorMessage = "Please use only alphabets in the name of the graduate course.")]
        public string GraduateCourseName { get; set; }

        //property to store active status
        [Required]
        public bool Active { get; set; } = true;

    }
}
