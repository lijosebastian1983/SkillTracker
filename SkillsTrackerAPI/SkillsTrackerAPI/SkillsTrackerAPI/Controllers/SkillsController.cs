using SkillsTrackerBusinessLayer;
using SkillsTrackerBusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SkillsTrackerAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SkillsController : ApiController
    {
        SkillsBusiness skillDetailBusiness = new SkillsBusiness();        
        [ActionName("GetAllSkills")]
        [HttpGet]
        public List<SkillsModel> GetAllSkills()
        {
            return skillDetailBusiness.GetAllSkills();
        }
        
        [ActionName("AddSkills")]
        [HttpPost]
        public string AddSkills(SkillsModel skillsModel)
        {
            return skillDetailBusiness.AddSkills(skillsModel);
        }
    }
}
