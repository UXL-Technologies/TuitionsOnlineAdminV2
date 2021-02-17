//Authors: SA, BM, SM
//Date:11-Jan-2021
//Aim:  implementing the inteface ISubjectRepository

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.CoreBusiness.Entities;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext instanceOfDbContext;
        //constructor dependency injection
        public SubjectRepository(TuitionsOnlineAdminDbContext instanceOfDbContext)
        {
            this.instanceOfDbContext = instanceOfDbContext;

        }
        //To create a single record for Subject
        public string CreateSubjectRepository(Subject subject)
        {
            try {
                instanceOfDbContext.Subject.Add(subject);
                instanceOfDbContext.SaveChanges();
                return "done";
            }
            catch (Exception) {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_SUBJECT;
            }

        }

        //Authors: SA, BM, SM
        // Date:15-Jan-2021
        //To view Subject based on the search criteria 
        public List<Subject> ViewSubjectRepository(string searchKey)
        {
            try {
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
            catch (Exception) {
                List<Subject> subjectList = new List<Subject>();
                return subjectList = null;


            }
            //if the seach key is present the list is displayed

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
