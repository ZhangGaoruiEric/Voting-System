using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystem.data.IDAO
{
    interface IVotingSystemDAO
    {
        
        IList<VotingSystem.data.Topic_Recording> GetTopicRecordings();
        VotingSystem.data.Topic_Recording GetTopicDetails(int id);
        void CreateTopic(Topic_Recording topic);
        void EditTopic(Topic_Recording topic);
        void DeleteTopic(Topic_Recording topic);


        
   
        IList<VotingSystem.data.User_Recording> GetUserRecordings();
        VotingSystem.data.User_Recording GetUserDetails(int id);
        void UserRegister(User_Recording user);  
        void EditUser(User_Recording user);


        IList<VotingSystem.data.User_Recording> GetAdministratorRecordings();
        void AdministratorRegister(User_Recording Administrator);
        VotingSystem.data.User_Recording GetAdministratorDetails(int id);
        void EditAdministrator(User_Recording Administrator);
    }
}
