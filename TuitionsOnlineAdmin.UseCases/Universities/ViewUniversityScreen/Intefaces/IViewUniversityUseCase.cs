//Authors: SA, BM, SM,BA,KK
//Date:25-Jan-2021
//Aim: defining the Interface for view UniversityUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.Universities.ViewUniversityScreen.Intefaces
{
   public interface IViewUniversityUseCase
    {
        //Declaring a method to view the University
        List<University> ViewUniversity(string searchKey);
    }
}
