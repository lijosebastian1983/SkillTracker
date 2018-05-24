using SkillsTrackerBusinessLayer.Models;
using SkillTrackerDataAccess;
using SkillTrackerDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTrackerBusinessLayer
{
    public class AssociateBusiness
    {
        public AssociateModel GetAssociateByID(string associateId)
        {
            AssociateDAO associateDAO = new AssociateDAO();
            Associate associate = associateDAO.GetAssociateByID(associateId);
            AssociateSkillsDAO associateSkillsDAO = new AssociateSkillsDAO();
            //List<AssociateSkillsModel> associateSkillsList = associateSkillsDAO.GetAssociateSkillsByID(associateId)
            //    .Select(x=> new AssociateSkillsModel { AssociateSkillsId = x.Associate_Skills_ID, SkillId = x.Skill_ID, SkillRate = x.Skill_Rate}).ToList();
            return new AssociateModel
            {
                AssociateDetailsId = associate.Associate_Details_ID,
                AssociateId = associate.Associate_ID,
                Name = associate.Name,
                Email = associate.Email,
                Mobile = associate.Mobile,
                Pic = associate.Pic,
                Status = associate.Status,
                Level = associate.Level,
                Remark = associate.Remark,
                OtherSkills = associate.OtherSkills,
                Weekness = associate.Weekness,
                Strength = associate.Strength,
                AssociateSkills = associate.AssociateSkillsList
                .Select(x => new AssociateSkillsModel
                {
                    AssociateSkillsId = x.Associate_Skills_ID,
                    SkillRate = x.Skill_Rate,
                    SkillId = x.Associate_Skills.Skill_ID,
                    SkillName = x.Associate_Skills.Skill_Name                   
                }).ToList()
            };
        }
        public List<AssociateModel> GetAllAssociates()
        {
            List<AssociateModel> associateModelList = new List<AssociateModel>();
            AssociateDAO associateDAO = new AssociateDAO();
            //associateModelList = 
            return associateDAO.GetAllAssociates()
            .Select(x => new AssociateModel
            {
                AssociateDetailsId = x.Associate_Details_ID,
                AssociateId = x.Associate_ID,
                Name = x.Name,
                Email = x.Email,
                Mobile = x.Mobile,
                Pic = x.Pic,
                Status = x.Status,
                Level = x.Level,
                Remark = x.Remark,
                OtherSkills = x.OtherSkills,
                Weekness = x.Weekness,
                Strength = x.Strength,
                AssociateSkills = x.AssociateSkillsList
            .Select(y => new AssociateSkillsModel
            {
                AssociateSkillsId = y.Associate_Skills_ID,
                SkillRate = y.Skill_Rate,
                SkillId = y.Associate_Skills.Skill_ID,
                SkillName = y.Associate_Skills.Skill_Name                
            }).ToList()
            }).ToList();
            //List<AssociateSkillsModel> associateSkillsModelList = null;
            //AssociateSkillsDAO associateSkillsDAO = new AssociateSkillsDAO();
            //foreach (AssociateModel associateModel in associateModelList)
            //{
            //    associateSkillsModelList = associateSkillsDAO.GetAssociateSkillsByID(associateModel.AssociateId)
            //        .Select(x => new AssociateSkillsModel
            //        {
            //            AssociateSkillsId = x.Associate_Skills_ID,
            //            SkillId = x.Skill_ID,
            //            SkillRate = x.Skill_Rate
            //        }).ToList();
            //    associateModel.AssociateSkills = associateSkillsModelList;
            //}
            //return associateModelList;
        }
        public string AddAssociateDetails(AssociateModel associateDetails)
        {
            AssociateDAO associateDAO = new AssociateDAO();
            Associate associate = new Associate
            {
                Associate_ID = associateDetails.AssociateId,
                Name = associateDetails.Name,
                Email = associateDetails.Email,
                Mobile = associateDetails.Mobile,
                Pic = associateDetails.Pic,
                Status = associateDetails.Status,
                Level = associateDetails.Level,
                Remark = associateDetails.Remark,
                OtherSkills = associateDetails.OtherSkills,
                Weekness = associateDetails.Weekness,
                Strength = associateDetails.Strength,
                AssociateSkillsList = associateDetails.AssociateSkills
                .Select(x => new AssociateSkills
                {
                    Associate_ID = associateDetails.AssociateId,
                    Associate_Skills_ID = x.AssociateSkillsId,
                    Associate_Details_ID = associateDetails.AssociateDetailsId,
                    Skill_ID = x.SkillId,
                    Skill_Rate = x.SkillRate,                
                }).ToList()
            };
            associateDAO.AddAssociate(associate);
            //if (associateDAO.AddAssociate(associate) && associateDetails.AssociateSkills != null && associateDetails.AssociateSkills.Count > 0)
            //{
            //    AssociateSkillsDAO associateSkillsDAO = new AssociateSkillsDAO();
            //    associateSkillsDAO.AddAssociateSkills(associateDetails.AssociateSkills.Select(x => new AssociateSkills { Associate_ID = associate.Associate_ID, Skill_ID = x.SkillId, Skill_Rate = x.SkillRate }).ToList());
            //}
            return "Associate details added successfully";
        }
        public List<AssociateSkillsModel> GetAllAssociateSkills()
        {
            List<AssociateSkillsModel> associateSkillsModel = new List<AssociateSkillsModel>();
           SkillsDAO skillsDAO = new SkillsDAO();
            //associateModelList = 
            return skillsDAO.GetAllSkills()
            .Select(x => new AssociateSkillsModel
            {               
                SkillId = x.Skill_ID,                
                SkillName = x.Skill_Name,                           
            }).ToList();          
        }
    }
}
