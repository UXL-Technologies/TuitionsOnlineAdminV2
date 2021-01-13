//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim: defining the entity for subject

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class Subject
    {
       
            //property to store SubjectId
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public Guid SubjectId { get; set; }

            //property to store SubjectName 
            [Required(ErrorMessage = "Please enter the name of the subject.")]
            [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
            [MaxLength(150, ErrorMessage = "The subject name you have entered is too long. Please restrict the name to less than 150 alphabets.")]
            [RegularExpression(@"^[A-Za-z\s]{1,}[\.]{0,}[A-Za-z.\s]{0,}", ErrorMessage = "Please use only alphabets in the name of the subject.")]
            public string SubjectName { get; set; }

            //property to store Active status
            public bool Active { get; set; } = true;
        }
    }

