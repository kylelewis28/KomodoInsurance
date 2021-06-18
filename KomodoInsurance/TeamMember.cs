using KomodoInsurance.POCOs.ENUMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamTracker.POCOs
{
    public class Developer
    {
        public int ID { get; set; }
        public string DeveloperName { get; set; }

        public DeveloperRoleType DeveloperRoleType { get; set; }

        public Developer()
        {
                
        }

        public Developer(string developerName, DevloperRoleType developerrole)
        {
            DeveloperName = developerName;
            DeveloperRole = deevloperRole;
        }
    }
}
