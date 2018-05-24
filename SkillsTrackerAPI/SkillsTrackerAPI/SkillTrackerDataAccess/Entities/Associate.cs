using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTrackerDataAccess.Entities
{
    public class Associate
    {
        [Key]
        public int Associate_Details_ID { get; set; }
        public string Associate_ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Pic { get; set; }
        public bool Status_Green { get; set; }
        public bool Status_Blue { get; set; }
        public bool Status_Red { get; set; }
        public bool Level_1 { get; set; }
        public bool Level_2 { get; set; }
        public bool Level_3 { get; set; }
        public string Status { get; set; }
        public string Level { get; set; }
        public string Remark { get; set; }
        public string Strength { get; set; }
        public string Weekness { get; set; }
        public string OtherSkills { get; set; }

        [ForeignKey("Associate_Details_ID")]
        public List<AssociateSkills> AssociateSkillsList { get; set; }

    }
}
