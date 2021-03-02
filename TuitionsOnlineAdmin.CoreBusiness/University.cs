//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:25-Feb-2021
//Aim: defining the entity for University 

using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class University
    {
        //property to store UniversityId 
        public int UniversityId { get; set; }
        //property to store UniversityName 
        public string UniversityName { get; set; }
        //property to store Active 
        public bool Active { get; set; }


    }
}
