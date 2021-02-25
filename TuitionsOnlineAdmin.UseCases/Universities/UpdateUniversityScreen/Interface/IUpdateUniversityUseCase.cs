//Authors: SA, BM, SM,KK,BA
//Date:25-Jan-2021
//Aim: defining the Interface for UniversityUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.Universities.UpdateUniversityScreen.Interface
{
    public interface IUpdateUniversityUseCase
    {
        //Declaring a method to update the University
        string UpdateUniversity(University university);
    }
}
