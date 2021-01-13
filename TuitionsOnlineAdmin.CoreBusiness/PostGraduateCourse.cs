//Authors: SA, BM, SM
//Date:08-Jan-2021
//Aim: defining the entity for Postgraduate course

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
    public class PostGraduateCourse
    {
        //property to store PostGraduateCourseId
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PostGraduateCourseId { get; set; }

        //property to store PostGraduateCourseName 
        [Required(ErrorMessage = "Please enter the name of the post graduate course.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        [MaxLength(300, ErrorMessage = "The post graduate course name you have entered is too long. Please restrict the name to less than 300 alphabets.")]
        [RegularExpression(@"^[A-Za-z\s]{1,}[\.]{0,}[A-Za-z.\s]{0,}", ErrorMessage = "Please use only alphabets in the name of the post graduate course.")]
        public string PostGraduateCourseName { get; set; }

        //property to store Active status
        public bool Active { get; set; } = true;
    }
}
