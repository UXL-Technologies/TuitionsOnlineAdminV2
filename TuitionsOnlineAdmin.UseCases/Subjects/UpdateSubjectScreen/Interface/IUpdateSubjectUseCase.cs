﻿//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:15-Jan-2021
//Aim: defining the Interface for Update SubjectUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.Subjects.UpdateSubjectScreen.Interface
{
   public interface IUpdateSubjectUseCase
    {

        //Declaring a method to update the Subject
        string UpdateSubject(Subject subject);
    }
}
