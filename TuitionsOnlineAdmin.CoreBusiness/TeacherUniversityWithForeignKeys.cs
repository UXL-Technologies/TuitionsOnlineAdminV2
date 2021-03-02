//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:26-Feb-2021
//Aim: defining the entity for TeacherUniversityWithForeignKeys 

using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class TeacherUniversityWithForeignKeys : TeacherUniversity
    {
        //property to store TeacherName
        public string TeacherName { get; set; }
        //property to store UniversityName
        public string UniversityName { get; set; }
    }
}
