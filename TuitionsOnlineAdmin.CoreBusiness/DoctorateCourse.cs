
//Authors: SA, BM, SM
// Date:08-Jan-2021
//Aim: defining the entity for doctorate course


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class DoctorateCourse
    {
        //property to store DoctorateCourseId 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorateCourseId { get; set; }

        //property to store DoctorateCourseName
        [Column(TypeName = "varchar(150)")]
        [Required(ErrorMessage = "Please enter the name of the doctorate course.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        [MaxLength(150, ErrorMessage = "The  doctorate course name you have entered is too long. Please restrict the name to less than 150 alphabets.")]
        [RegularExpression(@"^[A-Za-z\s]{1,}[\.]{0,}[A-Za-z.\s]{0,}", ErrorMessage = "Please use only alphabets in the name of the  doctorate course.")]
        public string DoctorateCourseName { get; set; }

        //property to store Active status 
        [Required]
        public bool Active { get; set; } = true;
    }
}
