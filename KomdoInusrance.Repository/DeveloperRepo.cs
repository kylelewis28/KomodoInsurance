using BasketBallTeamTracker.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBallTeamTracker.Repository
{
    public class PlayerRepo
    {
        
        private readonly List<Player> _developerRepository = new List<Developer>();
        
                private int _count = 5;


        

    
        public bool CreateDeveloper(Developer developer)
        {
            if (developer is null)
            {
                return false;
            }
            _count++;
            Team.ID = _count;
            _DevTeamRepository.Add(TeamMember);
            return true;
        }

        //R. read ->Get all Developers
        public List<Developer> GetDeveloper() 
        {
            return _developerRepository;
        }

        //R. read-> Get Developers by Id (helper method)
        public Developer GetDeveloperById(int id)
        {
            
            foreach (Developer developer in _developerRepository)
            {
                if (Team.ID==id)
                {
                    return player;
                }
            }
            return null;
        }
        public bool UpdateDeveloper(int id, Developer newDeveloper)
        {
            
            Developer developer = GetDeveloperById(id);

            
            if (Developer != null)
            {
                Team.ID = id;
                developer.developerName = newDeveloper.DeveloperName;
                Developer.DevloperRole = newDeveloper.DeveloperRole;
                return true;
            }
            else
            {
                return false;
            }

        }

        
        public bool DeleteTeamMember(int id)
        {
            Deevloper developer = GetDeveloperById(id);

            
            if (Developer==null)
            {
                return false;
            }
            else
            {
                _developerRepository.Remove(developer);
                return true;
            }
        }

    }
}
