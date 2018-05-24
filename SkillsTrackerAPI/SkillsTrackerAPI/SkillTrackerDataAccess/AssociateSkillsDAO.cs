using SkillTrackerDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTrackerDataAccess
{
    public class AssociateSkillsDAO
    {
        public List<AssociateSkills> GetAllAssociateSkills()
        {
            List<AssociateSkills> associateSkillsList = new List<AssociateSkills>();
            using (SkillTrackerDBContext db = new SkillTrackerDBContext())
            {
                associateSkillsList = db.AssociateSkillsCollection.ToList();
            }
            return associateSkillsList;
        }
        //public List<AssociateSkills> GetAssociateSkillsByID(string associateId)
        //{
        //    List<AssociateSkills> associateSkills = new List<AssociateSkills>();
        //    using (SkillTrackerDBContext db = new SkillTrackerDBContext())
        //    {
        //        associateSkills = db.AssociateSkillsCollection.Where(x => x.Associate_ID == associateId).ToList();
        //    }
        //    return associateSkills;
        //}

        //public bool AddAssociateSkills(List<AssociateSkills> associateSkillsList)
        //{
        //    using (SkillTrackerDBContext db = new SkillTrackerDBContext())
        //    {
        //        db.AssociateSkillsCollection.AddRange(associateSkillsList);
        //        db.SaveChanges();
        //    }
        //    return true;
        //}
    }
}
