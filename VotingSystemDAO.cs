using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.data.IDAO;

namespace VotingSystem.data.DAO
{
   public class VotingSystemDAO:IVotingSystemDAO
    {
        private VotingSystemEntities _context;
        public VotingSystemDAO()
        {
            _context = new VotingSystemEntities();
        }

        public IList<Topic_Recording> GetTopicRecordings()
        {
            IQueryable<Topic_Recording> _recordings;
            _recordings = from recording
                          in _context.Topic_Recording
                          select recording;
            return _recordings.ToList<Topic_Recording>();
        }

        public Topic_Recording GetTopicDetails(int id)
        {
            IQueryable<Topic_Recording> _recording;
            _recording = from recording
                         in _context.Topic_Recording
                         where recording.Id == id
                         select recording;
            return _recording.ToList<Topic_Recording>().First();
        }        

        public void CreateTopic(Topic_Recording topic)
        {
            _context.Topic_Recording.Add(topic);
            _context.SaveChanges();
        }
       
        public void EditTopic(Topic_Recording topic)
        {
            Topic_Recording record = GetTopicDetails(topic.Id);
            record.TopicName = topic.TopicName;
            record.TopicSponsor = topic.TopicSponsor;
            record.CandidateA = topic.CandidateA;
            record.AScore = topic.AScore;
            record.CandidateB = topic.CandidateB;
            record.BScore = topic.BScore;
            record.Id = topic.Id;
            _context.SaveChanges();
        }

        public void DeleteTopic(Topic_Recording topic)
        {
            _context.Topic_Recording.Remove(topic);
            _context.SaveChanges();
        }




        

        public IList<User_Recording> GetUserRecordings()
        {
            IQueryable<User_Recording> _recordings;
            _recordings = from recording
                          in _context.User_Recording
                          select recording;
            return _recordings.ToList<User_Recording>();
        }
        
        public void UserRegister(User_Recording user)
        {
            _context.User_Recording.Add(user);
            _context.SaveChanges();
        }

        public User_Recording GetUserDetails(int id)
        {
            IQueryable<User_Recording> _recording;
            _recording = from recording
                         in _context.User_Recording
                         where recording.Id == id
                         select recording;
            return _recording.ToList<User_Recording>().First();
        }

        public void EditUser(User_Recording user)
        {
            User_Recording record = GetUserDetails(user.Id);
            record.UserName = user.UserName;
            record.UserId = user.UserId;
            record.Password = user.Password;
            record.AccountLevel = user.AccountLevel;
             
            _context.SaveChanges();
        }






        public IList<User_Recording>GetAdministratorRecordings()
        {
            IQueryable<User_Recording> _recordings;
            _recordings = from recording
                          in _context.User_Recording
                          select recording;
            return _recordings.ToList<User_Recording>();
        }
        public User_Recording GetAdministratorDetails(int id)
        {
            IQueryable<User_Recording> _recording;
            _recording = from recording
                         in _context.User_Recording
                         where recording.Id == id
                         select recording;
            return _recording.ToList<User_Recording>().First();
        }

        public void EditAdministrator(User_Recording Administrator)
        {
            User_Recording record = GetAdministratorDetails(Administrator.Id);
            record.UserName = Administrator.UserName;
            record.UserId = Administrator.UserId;
            record.Password = Administrator.Password;
            record.AccountLevel = Administrator.AccountLevel;

            _context.SaveChanges();
        }
        public void AdministratorRegister(User_Recording Administrator)
        {
            _context.User_Recording.Add(Administrator);
            _context.SaveChanges();
        }

        
    }
}
