﻿//Authors: SA, BM, SM
//Date:15-Jan-2021
//Aim: defining the Interface for GradeUsecase ;


using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.Grades.UpdateGradeScreen.Interface
{
    public interface IUpdateGradeUseCase
    {
        //Declaring a method to update the Grade
        string UpdateGrade(Grade grade);
    }
}
