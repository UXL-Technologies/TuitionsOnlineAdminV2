//Authors: SA, BM, SM
//Date:18-Jan-2021
//Aim: defining the Interface for  ViewCityUseCase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.Cities.ViewCityScreen.Interfaces
{
    public interface IViewCityUseCase
    {
        //Declaring a method to view the City
        List<City> ViewCity(string searchKey);
    }
}
