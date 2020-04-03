using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using COVID19Alert.Data;
using COVID19Alert.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace COVID19Alert.Controllers
{
    [Authorize(Roles = "MedicalHotline")]
    public class MedicalHotlineController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicalHotlineController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MedicalHotline
        public ActionResult Index()
        {
            var viewModel = new MedicalHotlineViewModel();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var medHotline = _context.MedicalHotlines.Where(m => m.IdentityUserId == userId).ToList();
            if (medHotline == null)
            {
                return RedirectToAction("Create");
            }

            return View(medHotline);
        }

        // GET: MedicalHotline/Details/5
        public ActionResult Details(int id)
        {
            var viewModel = new MedicalHotlineViewModel();
            var medHotline = _context.MedicalHotlines.Include(m => m.Address).FirstOrDefault(m => m.Id == id);
            viewModel.MedicalHotline = medHotline;
            return View(viewModel);
        }

        // GET: MedicalHotline/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicalHotline/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MedicalHotlineViewModel viewModel)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var medHotline = viewModel.MedicalHotline;
            medHotline.IdentityUserId = userId;
            _context.MedicalHotlines.Add(viewModel.MedicalHotline);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: MedicalHotline/Edit/5
        public ActionResult Edit(int id)
        {
            var viewModel = new MedicalHotlineViewModel();
            var medHotline = _context.MedicalHotlines.Include(m => m.Address).FirstOrDefault(m => m.Id == id);
            viewModel.MedicalHotline = medHotline;
            return View(viewModel);
        }

        // POST: MedicalHotline/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MedicalHotlineViewModel viewModel)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            viewModel.MedicalHotline.IdentityUserId = userId;
            var medHotlineDb = _context.MedicalHotlines.Include(m => m.Address).FirstOrDefault(r => r.Id == id);
            medHotlineDb.DoctorsName = viewModel.MedicalHotline.DoctorsName;
            medHotlineDb.NursesName = viewModel.MedicalHotline.NursesName;
            medHotlineDb.PhoneNumber = viewModel.MedicalHotline.PhoneNumber;
            medHotlineDb.Address.Street = viewModel.MedicalHotline.Address.Street;
            medHotlineDb.Address.City = viewModel.MedicalHotline.Address.City;
            medHotlineDb.Address.State = viewModel.MedicalHotline.Address.State;
            medHotlineDb.Address.ZipCode = viewModel.MedicalHotline.Address.ZipCode;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: MedicalHotline/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MedicalHotline/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MedicalHotline/Hotlines/5
        public ActionResult Hotlines(int id)
        {
            var viewModel = new MedicalHotlineViewModel();
            var medHotline = _context.MedicalHotlines.Include(m => m.Address).FirstOrDefault(m => m.Id == id);
            viewModel.MedicalHotline = medHotline;
            return View(viewModel);
        }
    }
}