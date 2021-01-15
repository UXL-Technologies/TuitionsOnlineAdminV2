//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim: defining the entity for subject

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        public SubjectRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;

        }
        //To create a single record for Subject
        public void CreateSubjectRepository(Subject subject)
        {
            instanceOfDbContext.Subject.Add(subject);
            instanceOfDbContext.SaveChanges();

        }

        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //To view Subject based on the search criteria 
        public List<Subject> ViewSubjectRepository(string searchKey)
        {

            //if the seach key is present the list is displayed
            if (searchKey != null)
            {
                List<Subject> subjectList = new List<Subject>();
                subjectList = instanceOfDbContext.Subject.Where(s => s.SubjectName.Contains(searchKey)).ToList();
                return subjectList;
            }
            //if not entire list of data is displayed
            else

            {
                var subjectList = instanceOfDbContext.Subject.ToList();
                return subjectList;
            }
        }
        //To update Subject
        public string UpdateSubjectRepository(Subject subject)
        {
            Subject subjectToBeUpdated = instanceOfDbContext.Subject.FirstOrDefault(s => s.SubjectId == subject.SubjectId);
            subjectToBeUpdated = subject;
            instanceOfDbContext.Subject.Append(subjectToBeUpdated);
            instanceOfDbContext.SaveChanges();
            return "Done";

        }
    }
}
