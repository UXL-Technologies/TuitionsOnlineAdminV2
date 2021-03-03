//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:26-Feb-2021
//Aim:  class to implement create Teacher University
using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.TeacherUniversities.CreateTeacherUniversityScreen.Interfaces;

namespace TuitionsOnlineAdmin.UseCases.TeacherUniversities.CreateTeacherUniversityScreen
{
  public class CreateTeacherUniversityUseCase : ICreateTeacherUniversityUseCase
    {
        // Aim: Property dependency injection of IUnitOfWork for creating the teacher 

        private readonly IUnitOfWork diIUnitOfWork;

        // Aim: Constructor dependency injection of IUnitOfWork for creating the teacher University
        public CreateTeacherUniversityUseCase(IUnitOfWork diIUnitOfWork)

        {
            this.diIUnitOfWork = diIUnitOfWork;
        }

        //Aim : The CreateUniversityUseCase method is responsible to create the teacher University.
        public string CreateTeacherUniversity(int teacherId, int selectedUniversities)
        {
            Console.WriteLine(teacherId);
            Console.WriteLine(selectedUniversities);
            var result = diIUnitOfWork.CreateTeacherUniversity(teacherId, selectedUniversities);
            return result;
        }
    }
}
