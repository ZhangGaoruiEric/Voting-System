using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace VotingSystem.Controllers
{
    public class VotingSystemController : Controller
    {
        // GET: VotingSystem
        private VotingSystem.Services.IService.IVotingSystemService _votingSystemService;
        
        public VotingSystemController()
        {
            _votingSystemService = new VotingSystem.Services.Service.VotingSystemService();
        }
       
        public ActionResult GetTopicRecordings()
        {
            return View("GetTopicRecordings", _votingSystemService.GetTopicRecordings());
        }

        // GET: VotingSystem/Details/5
        public ActionResult GetTopicDetails(int id)
        {
            return View("GetTopicDetails", _votingSystemService.GetTopicDetails(id));
        }

    

        // GET: VotingSystem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VotingSystem/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VotingSystem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VotingSystem/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VotingSystem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VotingSystem/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
