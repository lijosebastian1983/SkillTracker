using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTrackerDataAccess.Entities
{
    public class AssociateSkills
    {
        [Key]
        public int Associate_Skills_ID { get; set; }
        public int Associate_Details_ID { get; set; }
        public string Associate_ID { get; set; }
        public int Skill_ID { get; set; }
        public int Skill_Rate { get; set; }
        [ForeignKey("Skill_ID")]
        public Skills Associate_Skills { get; set; }

    }
}
