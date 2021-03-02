//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:11-Jan-2021
//Aim: defining the entity for HighSchoolBoard

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class HighSchoolBoard
    {
        //property to store HighSchoolBoardId 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HighSchoolBoardId { get; set; }
    
        //property to store HighSchoolBoardName 
        [Required(ErrorMessage = "Please enter the name of the high school board.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        [MaxLength(100, ErrorMessage = "The high school board name you have entered is too long. Please restrict the name to less than 100 alphabets.")]
        [RegularExpression(@"^[A-Za-z\s]{1,}[\.]{0,}[A-Za-z.\s]{0,}", ErrorMessage = "Please use only alphabets in the name of the high school board.")]
        public string HighSchoolBoardName { get; set; }
    
        //property to store Active status 
        public bool Active { get; set; } = true;
    }
}
