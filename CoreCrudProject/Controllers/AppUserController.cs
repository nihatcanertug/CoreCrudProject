using CoreCrudProject.DataLayer.Repositories.Interface;
using CoreCrudProject.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrudProject.Controllers
{
    public class AppUserController : Controller
    {
        private readonly IAppUserRepository _repo;

        public AppUserController(IAppUserRepository appUserRepository) => _repo = appUserRepository;
        
  
        public IActionResult Create() =>  View();

        [HttpPost]
        public IActionResult Create(AppUser appUser)
        {
            _repo.Create(appUser);
            return RedirectToAction("List");
        }
        public IActionResult List() => View(_repo.GetUser());


        public IActionResult Update(int id) => View(_repo.GetById(id));

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Update(AppUser appUser)
        {
            _repo.Edit(appUser);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return RedirectToAction("List");
        }



    }
}
