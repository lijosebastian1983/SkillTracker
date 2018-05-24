using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTrackerBusinessLayer.Models
{
    public class AssociateSkillsModel
    {
        public int AssociateSkillsId { get; set; }
        public int SkillId { get; set; }
        public int SkillRate { get; set; }
        public string SkillName { get; set; }
    }
}
