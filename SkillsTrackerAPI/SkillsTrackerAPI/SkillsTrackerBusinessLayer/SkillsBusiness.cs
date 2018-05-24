using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillTrackerDataAccess;
using SkillTrackerDataAccess.Entities;
using SkillsTrackerBusinessLayer.Models;

namespace SkillsTrackerBusinessLayer
{
    public class SkillsBusiness
    {
        public List<SkillsModel> GetAllSkills()
        {
            List<SkillsModel> skillModel = new List<SkillsModel>();
            SkillsDAO skillDAO = new SkillsDAO();
            skillModel = skillDAO.GetAllSkills().Select(x => new SkillsModel { SkillId = x.Skill_ID, SkillName = x.Skill_Name }).ToList();
            return skillModel;
        }

        public string AddSkills(SkillsModel skillsModel)
        {
            Skills skills = new Skills { Skill_ID = skillsModel.SkillId, Skill_Name = skillsModel.SkillName };
            SkillsDAO skillDAO = new SkillsDAO();
            return skillDAO.AddSkills(skills);            
        }
    }
}
