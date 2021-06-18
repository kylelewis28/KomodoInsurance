using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamTracker.POCOs
{
    public class Team
    {
        public int ID { get; set; }
        public string DevTeamSec { get; set; }
        public List<Developers> Developer { get; set; } = new List<Developer>();

        public Team()
        {

        }

        public Team(string DevteamName,List<Developer> developers)
        {
            DeveloperTeamName = DeveloperName;
            Developers = developer;
        }
    }
}
