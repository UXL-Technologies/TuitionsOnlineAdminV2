//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
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
        public int PostGraduateCourseId { get; set; }

        //property to store PostGraduateCourseName 
        [Column(TypeName = "varchar(150)")]
        [Required(ErrorMessage = "Please enter the name of the post graduate course.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        [MaxLength(150, ErrorMessage = "The post graduate course name you have entered is too long. Please restrict the name to less than 150 alphabets.")]
        [RegularExpression(@"^[A-Za-z\s]{1,}[\.]{0,}[A-Za-z.\s]{0,}", ErrorMessage = "Please use only alphabets in the name of the post graduate course.")]
        public string PostGraduateCourseName { get; set; }

        //property to store Active status
        [Required]
        public bool Active { get; set; } = true;
    }
}
