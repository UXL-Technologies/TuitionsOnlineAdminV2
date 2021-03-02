//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:15-Jan-2021
//Aim: implementing the inteface IGradeRepository

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class GradeRepository : IGradeRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        //constructor dependency injection
        public GradeRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;
        }

        //To create a single record for Grade
        public string CreateGradeRepository(Grade grade)
        {
            try {
                instanceOfDbContext.Grade.Add(grade);
                instanceOfDbContext.SaveChanges();
                return "done";
            }
            catch (Exception) {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_GRADE;
            }
         
        }

        //Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
        // Date:15-Jan-2021
        //To view Grade based on the search criteria 
        public List<Grade> ViewGradeRepository(string searchKey)
        {
            try {
                if (searchKey != null)
                {
                    List<Grade> gradeList = new List<Grade>();
                    gradeList = instanceOfDbContext.Grade.Where(s => s.GradeName.Contains(searchKey)).ToList();
                    return gradeList;
                }
                //if not entire list of data is displayed
                else

                {
                    var gradeList = instanceOfDbContext.Grade.ToList();
                    return gradeList;
                }
            }
            catch (Exception) {
                List<Grade> gradeList = new List<Grade>();
                return gradeList = null;

            }
            //if the seach key is present the list is displayed

        }

        //To update Grade
        public string UpdateGradeRepository(Grade grade)
        {
            try {
                Grade gradeToBeUpdated = instanceOfDbContext.Grade.FirstOrDefault(s => s.GradeId == grade.GradeId);
                gradeToBeUpdated = grade;
                instanceOfDbContext.Grade.Append(gradeToBeUpdated);
                instanceOfDbContext.SaveChanges();
                return "Done";
            }
            catch (Exception) {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_UPDATE_GRADE;
            }

        }
    }
}
