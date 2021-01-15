using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.Grades.UpdateGradeScreen.Interface;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;

namespace TuitionsOnlineAdmin.UseCases.Grades.UpdateGradeScreen
{
    public class UpdateGradeUseCase: IUpdateGradeUseCase
    {
        //property dependency injection
        private readonly IUnitOfWork instanceOfIUnitOfWork;

        //constructor dependency injection
        public UpdateGradeUseCase(IUnitOfWork instanceOfIUnitOfWork)
        {
            this.instanceOfIUnitOfWork = instanceOfIUnitOfWork;

        }
        //Calling the method update Grade in IunitOfwork
       
        public string UpdateGrade(Grade grade)
        {
            instanceOfIUnitOfWork.UpdateGrade(grade);
            return "done";
        }
    }
}
