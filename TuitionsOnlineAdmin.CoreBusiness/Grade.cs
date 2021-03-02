//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:12-Jan-2021
//Aim: defining the entity for grade


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class Grade
    {
        //property to store GradeId 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GradeId { get; set; }

        //property to store GradeName 
        [Column(TypeName = "varchar(150)")]
        [Required(ErrorMessage = "Please enter the grade.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        [MaxLength(150, ErrorMessage = "The grade you have entered is too long. Please restrict the grade to less than 150 alphabets.")]
        [RegularExpression(@"^[A-Za-z\s]{1,}[\.]{0,}[A-Za-z.\s]{0,}", ErrorMessage = "Please use either alphabets or numbers in the grade.")]
        public string GradeName { get; set; }

        //property to store Active status 
        public bool Active { get; set; } = true;
    }
}
