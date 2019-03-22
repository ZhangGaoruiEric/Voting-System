using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VotingSystem.data;

namespace VotingSystem.Controllers
{
    public class AdministratorController : Controller
    {
        private VotingSystem.Services.IService.IVotingSystemService _votingSystemService;
        // GET: Manager
        public AdministratorController()
        {
            _votingSystemService = new VotingSystem.Services.Service.VotingSystemService();
        }
        public ActionResult GetAdministratorRecordings()
        {
            return View("GetAdministratorRecordings", _votingSystemService.GetAdministratorRecordings());
        }

        public ActionResult GetAdministratorDetails(int id)
        {
            return View("GetAdministratorDetails", _votingSystemService.GetAdministratorDetails(id));
        }

        
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Manager/Create
        public ActionResult AdministratorRegister()
        {
            return View();
        }

        // POST: Manager/Create
        [HttpPost]
        public ActionResult AdministratorRegister(User_Recording Administrator)
        {
            try
            {
                // TODO: Add insert logic here
                _votingSystemService.AdministratorRegister(Administrator);
                return RedirectToAction("GetTopicRecordings", new { Controller = "VotingSystem" });
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult EditAdministrator(int id)
        {
            return View(_votingSystemService.GetAdministratorDetails(id));
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult EditAdministrator(int id, User_Recording Administrator)
        {
            try
            {
                // TODO: Add update logic here
                _votingSystemService.EditAdministrator(Administrator);
                return RedirectToAction("GetAdministratorDetails", new { Controller = "Administrator", id = Administrator.Id });
            }
            catch
            {
                return View();
            }
        }



        // GET: Manager/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Manager/Delete/5
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
