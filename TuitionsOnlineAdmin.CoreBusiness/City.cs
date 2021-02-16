//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim: defining the entity for city


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
    public class City
    {
        //property to store CityId 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }
        //property to store CityName 
        [Required(ErrorMessage = "Please enter the name of the city.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        [MaxLength(150, ErrorMessage = "The city name you have entered is too long. Please restrict the name to less than 150 alphabets.")]
        [RegularExpression(@"^[A-Za-z\s]{1,}[\.]{0,}[A-Za-z.\s]{0,}", ErrorMessage = "Please use only alphabets in the name of the city.")]
        public string CityName { get; set; }
        //property to store Active status 
        public bool Active { get; set; } = true;
        //property to store PinCode  
        [Required(ErrorMessage = "Please enter the Pincode of the City.")]
        [Range(6, 6, ErrorMessage = "Please enter a pin code of  6 digits.")]
        public int PinCode { get; set; }

    }
}
