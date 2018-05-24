using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTrackerBusinessLayer.Models
{
    public class AssociateModel
    {
        public int AssociateDetailsId { get; set; }
        public string AssociateId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Pic { get; set; }
        public string Status { get; set; }
        public string Level { get; set; }
        public string Remark { get; set; }
        public string Strength { get; set; }
        public string Weekness { get; set; }
        public string OtherSkills { get; set; }
        public List<AssociateSkillsModel> AssociateSkills { get; set; }
    }
}
