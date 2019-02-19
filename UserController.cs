using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VotingSystem.data;

namespace VotingSystem.Controllers
{
    public class UserController : Controller
    {
        private VotingSystem.Services.IService.IVotingSystemService _votingSystemService;
        // GET: User
        public UserController()
        {
            _votingSystemService = new VotingSystem.Services.Service.VotingSystemService();
        }
        public ActionResult GetUserRecordings()
        {
            return View("GetUserRecordings", _votingSystemService.GetUserRecordings());
        }

        // GET: User/Details/5
        public ActionResult GetUserDetails(int id)
        {
            return View("GetUserDetails",_votingSystemService.GetUserDetails(id));
        }

        // GET: User/Register
        public ActionResult UserRegister()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult UserRegister(User_Recording user)
        {
            try
            {
                // TODO: Add insert logic here
                _votingSystemService.UserRegister(user);
                return RedirectToAction("GetTopicRecordings", new { Controller = "VotingSystem" });
            }
            catch
            {
                return View();
            }
        }


        
        // GET: User/Edit/5
        public ActionResult EditUser(int id)
        {
            return View(_votingSystemService.GetUserDetails(id));
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult EditUser(int id, User_Recording user)
        {
            try
            {
                // TODO: Add update logic here
                _votingSystemService.EditUser(user);
                return RedirectToAction("GetUserDetails", new { Controller = "User", id = user.Id });
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
