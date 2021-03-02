//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:11-Jan-2021
//Aim: defining the entity for currency

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class Currency
    {
        //property to store CurrencyId
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CurrencyId { get; set; }

        //property to store CurrencyName 
        [Required(ErrorMessage = "Please enter the name of the currency.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        [MaxLength(150, ErrorMessage = "The currency name you have entered is too long. Please restrict the name to less than 150 alphabets.")]
        [RegularExpression(@"^[A-Za-z\s]{1,}[\.]{0,}[A-Za-z.\s]{0,}", ErrorMessage = "Please use only alphabets in the name of the currency.")]
        public string CurrencyName { get; set; }

        //property to store Active status 
        public bool Active { get; set; } = true;

        //property to store Default status 
        public bool Default { get; set; } = true;
    }
}
