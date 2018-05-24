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
    public class DashboardController : ApiController
    {
        AssociateBusiness associateBusiness = new AssociateBusiness();
        [ActionName("GetAllAssociates")]
        [HttpGet]
        public List<AssociateModel> GetAllAssociates()
        {
            return associateBusiness.GetAllAssociates();
        }

    }
}
