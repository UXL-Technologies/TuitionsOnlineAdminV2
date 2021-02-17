//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim: defining the Interface for CityUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.Cities.CreateCityScreen.Interfaces
{
    public interface ICreateCityUseCase
    {
        //Declaring a method to create the City
        string CreateCity(City city);
    }
}
