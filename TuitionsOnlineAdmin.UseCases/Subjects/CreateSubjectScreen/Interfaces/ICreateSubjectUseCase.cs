﻿//Authors: SA, BM, SM
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
        void CreateSubject(Subject subject);
    }
}