//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:25-Feb-2021
//Aim: defining the entity for University 

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class University
    {
        //property to store UniversityId 
        public int UniversityId { get; set; }

        //property to store UniversityName 
        [Required(ErrorMessage = "Please enter the name of the university.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        [MaxLength(150, ErrorMessage = "The university name you have entered is too long. Please restrict the name to less than 150 alphabets.")]
        [RegularExpression(@"^[A-Za-z\s]{1,}[\.]{0,}[A-Za-z.\s]{0,}", ErrorMessage = "Please use only alphabets in the name of the university.")]
       
        public string UniversityName { get; set; }
        //property to store Active 
        public bool Active { get; set; }


    }
}
