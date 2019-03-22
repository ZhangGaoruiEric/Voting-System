using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VotingSystem.data;

namespace VotingSystem.Controllers
{
    public class TopicController : Controller
    {
        private VotingSystem.Services.IService.IVotingSystemService _votingSystemService;
        // GET: Admin

            public TopicController()
        {
            _votingSystemService = new VotingSystem.Services.Service.VotingSystemService();
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult CreateTopic()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult CreateTopic(Topic_Recording topic)
        {
            try
            {
                // TODO: Add insert logic here
                _votingSystemService.CreateTopic(topic);
                return RedirectToAction("GetTopicRecordings", new { Controller ="VotingSystem"});
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult EditTopic(int id)
        {
            return View(_votingSystemService.GetTopicDetails(id));
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult EditTopic(int id, Topic_Recording topic)
        {
            try
            {
                // TODO: Add update logic here
                _votingSystemService.EditTopic(topic);
                return RedirectToAction("GetTopicRecordings", new {Controller = "VotingSystem",id = topic.Id});
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult DeleteTopic(int id)
        {
            return View(_votingSystemService.GetTopicDetails(id));
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult DeleteTopic(int id, Topic_Recording topic)
        {
            try
            {
                // TODO: Add delete logic here
                Topic_Recording _topic;
                _topic = _votingSystemService.GetTopicDetails(id);
                _votingSystemService.DeleteTopic(_topic);

                return RedirectToAction("GetTopicRecordings", new { Controller = "VotingSystem" });
            }
            catch
            {
                return View();
            }
        }
    }
}
