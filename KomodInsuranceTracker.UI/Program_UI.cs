using BasketBallTeamTracker.POCOs;
using BasketBallTeamTracker.POCOs.ENUMs;
using BasketBallTeamTracker.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devteamtracker.UI
{
    public class Program_UI
    {
        
        private readonly DevRepo _DevRepo = newDevRepo();

        public void Run()
        {
            Seed();
            RunApplication();
        }

      

        private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Welcome to the BasketBall Team Tracker\n" +
                                  "1. Create Team Member\n" +
                                  "2. View All Team Members\n" +
                                  "3. Select Indivisual Team Member\n" +
                                  "4. Update an Existing Team Member\n" +
                                  "5. Delete an Existing Team Member\n" +
                                  "30. Close DevTeam 2.0\n");

            
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CreateTeamMember();
                        break;
                    case "2":
                        ViewAllTeamMembers();
                        break;
                    case "3":
                        ViewIndivisualTeamMember();
                        break;
                    case "4":
                        UpdateExistingTeamMember();
                        break;
                    case "5":
                        DeleteTeamMember();
                        break;
                    case "30":
                        Console.Clear();
                        isRunning = false;
                        Console.WriteLine("Thank you , press any key to continue....");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid User input!");
                        break;
                }

                Console.Clear();
            }
        }

        private void DeveloperTeamMember()
        {
            Console.Clear();
            
            Console.WriteLine("First Name, Last Name:");
            string userInputPlayerName = Console.ReadLine();

            Console.WriteLine("Please Select A Team Role:\n" +
                              "1.Leading Developer\n" +
                              "2. Artist\n" +
                              "3.Programmer\n" +
                              "4.Level designer\n" +
                              "5.Front End Developer\n");

            int userInputPlayerPosition = int.Parse(Console.ReadLine());

            
            DeveloperRoleType developerrole = (DeveloperRoleType)userInputDeveloperRole;

            //construct the player:
            Developetype Developer = new developer(userInputDeveloperName, developerRole);

            //add the player to the repository:
           bool isSuccessful= _developerRepo.CreateDeveloper(Developer);

            if (isSuccessful)
            {
                Console.WriteLine($"{developer.DeveloperName} was successfully created!");
            }
            else
            {
                Console.WriteLine($"{developer.DeveloperName} was NOT successfully created!");
            }

        }

        private void ViewAllDevelopers()
        {
            Console.Clear();

            //need to make a list that we can use to assing the list of players that are in the repository
            List<Developer> Developer = _developerRepo.GetDevelopers();

            //we need a way to get details for every player... using a helper method...
            Console.Clear();
            foreach (Developer developer in Developer)
            {
                DisplayDeveloperInfo(developer);
            }

            Console.ReadKey();
        }

        
        private void DisplayPlayerInfo(Player player)
        {
            Console.WriteLine($"{teamMember.ID}\n" +
                              $"{developer.DeveloperName}\n" +
                              $"{developer.DeveloperRole}\n");

            Console.WriteLine("*************************************************");
        }

        private void ViewIndivisualTeamMember()
        {
            Console.Clear();

            Console.WriteLine("Please input an Existing Team Id");
            int userInputTeamId = int.Parse(Console.ReadLine());
            Developer developer = _deveoperRepo.GetTeamMemberById(userInputTeamId);
            if (developer!=null)
            {
                DisplayDeveloperInfo(developer);
            }
            else
            {
                Console.WriteLine("The Developer Was not Found in our Database");
            }

            Console.ReadKey();
        }

        private void UpdateExistingDeveloper()
        {
            Console.Clear();
            Console.WriteLine("Please input an Existing Team Id");
            int userInputTeamId = int.Parse(Console.ReadLine());


            Console.WriteLine("Please input Your name:");
            string userInputDeveloperName = Console.ReadLine();

            Console.WriteLine("Please input you Team Role:\n" +
                              "1.Lead Developer\n" +
                              "2.Artist \n" +
                              "3.Level designer\n" +
                              "4.Programmer\n" +
                              "5.Sound Engineer \n");

            int userInputDeveloperRole = int.Parse(Console.ReadLine());

            //now, I have to make a conversion from int to playerPositionType
            DeveloperRoleType developerRole = (PlayerPositionType)userInputDeveloperRole;

            //construct the player:
            Developer newDeveloper = new Player(userInputDeveloperName, userInputDeveloperrole);


            //we will implement the updatePlayer(int,Player)
            bool isSuccessful = _developerRepo.UpdateDevloper(userInputTeamId, newDeveloper);

            if (isSuccessful)
            {
                Console.WriteLine($"{newDeveloper.DeveloperName} was UPDATED!");
            }
            else
            {
                Console.WriteLine("Team Member  was NOT UPDATED!");
            }

        }

        private void DeleteExistingDeveloper()
        {
            Console.Clear();
            Console.WriteLine("Please input an Existing Team Id");
            int userInputTeamId = int.Parse(Console.ReadLine());

            bool isSuccessful = _devloperRepo.DeleteDeveloper(userInputTeamId);
            if (isSuccessful)
            {
                Console.WriteLine("Player was Deleted.");
            }
            else
            {
                Console.WriteLine("Developer was NOT DELETED!");
            }
        }

        private void Seed()
        {
            Developer developerA = new Developer("Nick",DeveloperRole.Lead_Developer);
            Developer developerB = new Developer("Austin",DeveloperRole.Artist);
            Developer developerC = new Developer("Steve",DeveloperRole.Level_Designer);
            Developer developerD = new Developer("Mark",DeveloperRole.Programmer);
            Developer developerE = new Developer("Louis",DeveloperRole.Sound_Engineer;

            
            _DevTeamRepo.CreateNewDeveloper(developerA);
            _DevTeamRepo.CreateNewDevloperr(developerB);
            _DevTeamRepo.CreateNewDeveloper(developerC);
            _DevTeamRepo.CreateNewDeveloper(developerD);
            _DevTeamRepo.CreateNewDeveloper(developerE);
        }
    }
}
