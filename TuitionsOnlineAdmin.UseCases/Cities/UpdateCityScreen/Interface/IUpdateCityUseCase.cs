//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:18-Jan-2021
//Aim: defining the Interface for CityUseCase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.Cities.UpdateCityScreen.Interface
{
   public interface IUpdateCityUseCase
    {
        //Declaring a method to update the City
        string UpdateCity(City city);
    }
}

