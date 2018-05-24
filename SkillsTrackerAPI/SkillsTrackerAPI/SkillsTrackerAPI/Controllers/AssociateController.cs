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
    public class AssociateController : ApiController
    {
        AssociateBusiness associateBusiness = new AssociateBusiness();
        [ActionName("AddAssociateDetails")]
        [HttpPost]
        public string AddAssociateDetails(AssociateModel associateDetails)
        {
            return associateBusiness.AddAssociateDetails(associateDetails);
        }
       
        [ActionName("GetAssociateByID")]
        [HttpGet]
        public AssociateModel GetAssociateByID(string associateId)
        {
            return associateBusiness.GetAssociateByID(associateId);
        }
        [ActionName("GetAllAssociateSkills")]
        [HttpGet]
        public List<AssociateSkillsModel> GetAllAssociateSkills()
        {
            return associateBusiness.GetAllAssociateSkills();
        }
    }
}
