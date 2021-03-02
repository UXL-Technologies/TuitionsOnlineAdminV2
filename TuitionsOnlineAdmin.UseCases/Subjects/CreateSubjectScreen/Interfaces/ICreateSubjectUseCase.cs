//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:11-Jan-2021
//Aim: defining the Interface for SubjectUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.Subjects.CreateSubjectScreen.Interfaces
{
   public interface ICreateSubjectUseCase
    {
        //Declaring a method to create the Subject
        string CreateSubject(Subject subject);
    }
}
