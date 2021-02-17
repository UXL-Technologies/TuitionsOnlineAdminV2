//Authors: SA, BM, SM
//Date:18-Jan-2021
//Aim: defining the Interface for CityUseCase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.Cities.UpdateCityScreen.Interface
{
   public interface IUpdateCityUseCase
    {
        //Declaring a method to update the City
        string UpdateCity(City city);
    }
}

