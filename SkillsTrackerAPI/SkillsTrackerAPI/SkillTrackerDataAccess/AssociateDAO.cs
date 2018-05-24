using SkillTrackerDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTrackerDataAccess
{
    public class AssociateDAO
    {
        public List<Associate> GetAllAssociates()
        {
            List<Associate> associateList = new List<Associate>();
            using (SkillTrackerDBContext db = new SkillTrackerDBContext())
            {
                associateList = db.AssociateCollection.ToList();
            }
            return associateList;
        }

        public Associate GetAssociateByID(string associateId)
        {
            Associate associate = new Associate();
            using (SkillTrackerDBContext db = new SkillTrackerDBContext())
            {
                associate = db.AssociateCollection.FirstOrDefault(x => x.Associate_ID == associateId);
            }
            return associate;
        }

        public bool AddAssociate(Associate associate)
        {
            using (SkillTrackerDBContext db = new SkillTrackerDBContext())
            {
                db.AssociateCollection.Add(associate);
                db.SaveChanges();
            }
            return true;
        }
    }
}
