//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Repository for Grade

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
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        public GradeRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;
        }

        //To create a single record for Grade
        public void CreateGradeRepository(Grade grade)
        {
            instanceOfDbContext.Grade.Add(grade);
            instanceOfDbContext.SaveChanges();
        }

        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //To view Grade based on the search criteria 
        public List<Grade> ViewGradeRepository(string searchKey)
        {

            //if the seach key is present the list is displayed
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

        //To update Grade
        public string UpdateGradeRepository(Grade grade)
        {
            Grade gradeToBeUpdated = instanceOfDbContext.Grade.FirstOrDefault(s => s.GradeId == grade.GradeId);
            gradeToBeUpdated = grade;
            instanceOfDbContext.Grade.Append(gradeToBeUpdated);
            instanceOfDbContext.SaveChanges();
            return "Done";

        }
    }
}
