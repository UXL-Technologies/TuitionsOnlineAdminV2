﻿//Authors: SA, BM, SM
//Date:15-Jan-2021
//Aim: defining the Interface for view SubjectUsecase ;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness.Entities;

namespace TuitionsOnlineAdmin.UseCases.Subjects.ViewSubjectScreen.Interfaces
{
    public interface IViewSubjectUseCase
    {
        //Declaring a method to view the Subject
        List<Subject> ViewSubject(string searchKey);
    }
}
