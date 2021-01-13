using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.CreateTeacherBasicInformationScreen.Interfaces
{
  public interface ICreateTeacherBasicInformationUseCase
    {
        void CreateTeacherBasicInformation(TeacherBasicInformation teacherBasicInformation);
    }
}
