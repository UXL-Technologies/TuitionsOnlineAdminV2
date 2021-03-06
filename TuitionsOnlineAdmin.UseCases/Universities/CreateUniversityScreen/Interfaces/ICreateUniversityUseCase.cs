﻿//Authors: Shravan A, Bhavya MU, Sneha M, Karan Kumar , Bhargavi S Adiga
//Date:25-Jan-2021
//Aim: defining the Interface for UniversityUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.Universities.CreateUniversityScreen.Interfaces
{
   public interface ICreateUniversityUseCase
    {
        //Declaring a method to create the Subject
        string CreateUniversity(University university);
    }
}
