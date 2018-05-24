using SkillTrackerDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTrackerDataAccess
{
    public class SkillsDAO
    {
        public List<Skills> GetAllSkills()
        {
            List<Skills> skillsList = new List<Skills>();
            using (SkillTrackerDBContext db = new SkillTrackerDBContext())
            {
                skillsList = db.SkillsCollection.ToList();
            }
            return skillsList;
        }

        public string AddSkills(Skills skills)
        {            
            using (SkillTrackerDBContext db = new SkillTrackerDBContext())
            {
                db.SkillsCollection.Add(skills);
                db.SaveChanges();
            }
            return "Skills added successfully";
        }
    }
}
