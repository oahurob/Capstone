using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using COVID19Alert.ActionFilter;
using COVID19Alert.Data;
using COVID19Alert.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace COVID19Alert.Controllers
{
    [Authorize(Roles = "RegisteredUser")]
    public class RegisteredUsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegisteredUsersController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: RegisteredUsers
        public ActionResult Index()
        {
            var viewModel = new RegisteredUserViewModel();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var registeredUser = _context.RegisteredUsers.Where(r => r.IdentityUserId == userId).ToList();
            if(registeredUser == null)
            {
                return RedirectToAction("Create");
            }
            
            return View(registeredUser);
        }

        // GET: RegisteredUsers/Details/5
        public ActionResult Details(int id)
        {
            var viewModel = new RegisteredUserViewModel();
            var regUser = _context.RegisteredUsers.Include(r => r.HouseHold).FirstOrDefault(r => r.Id == id);
            viewModel.RegisteredUser = regUser;
            return View(viewModel);
        }

        // GET: RegisteredUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisteredUsers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisteredUserViewModel viewModel)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var registeredUser = viewModel.RegisteredUser;
            registeredUser.IdentityUserId = userId;
                _context.RegisteredUsers.Add(viewModel.RegisteredUser);
                _context.SaveChanges();
                return RedirectToAction("Index");
        }

        // GET: RegisteredUsers/Edit/5
        public ActionResult Edit(int id)
        {
            var viewModel = new RegisteredUserViewModel();
            var regUser = _context.RegisteredUsers.Include(r => r.HouseHold).FirstOrDefault(r => r.Id == id);
            viewModel.RegisteredUser = regUser;
            return View(viewModel);
        }

        // POST: RegisteredUsers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, RegisteredUserViewModel viewModel)
        {
            //try to add try and catch to every method
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            viewModel.RegisteredUser.IdentityUserId = userId;
            var regUserDb = _context.RegisteredUsers.Include(r => r.HouseHold).FirstOrDefault(r => r.Id == id);
            regUserDb.FirstName = viewModel.RegisteredUser.FirstName;
            regUserDb.LastName = viewModel.RegisteredUser.LastName;
            regUserDb.DOB = viewModel.RegisteredUser.DOB;
            regUserDb.PreferredStore = viewModel.RegisteredUser.PreferredStore;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: RegisteredUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var regUser = _context.RegisteredUsers.Where(r => r.IdentityUserId == userId).Include(l => l.HouseHold).FirstOrDefault(l => l.Id == id);

            if (regUser == null)
            {
                return NotFound();
            }

            return View(regUser);
        }

        // POST: RegisteredUsers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var regUser = _context.RegisteredUsers.Find(id);
            _context.RegisteredUsers.Remove(regUser);
            _context.SaveChanges();


            return RedirectToAction("Index");

        }
    }
}