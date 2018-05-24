using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SkillTrackerDataAccess.Entities;

namespace SkillTrackerDataAccess
{
    public class SkillTrackerDBContext : DbContext
    {
        public SkillTrackerDBContext() : base("name = SkillTrackerConn") { }

        public virtual DbSet<Skills> SkillsCollection { get; set; }
        public virtual DbSet<Associate> AssociateCollection { get; set; }
        public virtual DbSet<AssociateSkills> AssociateSkillsCollection { get; set; }
    }
}
