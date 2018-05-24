using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTrackerDataAccess.Entities
{
    public class Skills
    {
        [Key]
        public int Skill_ID { get; set; }
        public string Skill_Name { get; set; }
    }
}
