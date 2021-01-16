using CoreCrudProject.DataLayer.Context;
using CoreCrudProject.DataLayer.Repositories.Interface;
using CoreCrudProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrudProject.DataLayer.Repositories.Concrete
{
    public class AppUserRepository : IAppUserRepository
    {
        private ProjectContext _context;

        public AppUserRepository(ProjectContext projectContext) => _context = projectContext;

        public void Create(AppUser appUser)
        {
            _context.AppUsers.Add(appUser);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var appUser = GetById(id);
            if (appUser != null)
            {
                _context.AppUsers.Remove(appUser);
                _context.SaveChanges();
            }
        }

        public void Edit(AppUser appUser)
        {
            _context.AppUsers.Update(appUser);
            _context.SaveChanges();
        }

        public AppUser GetById(int id) => _context.AppUsers.FirstOrDefault(x => x.Id == id);

        public List<AppUser> GetUser() => _context.AppUsers.Where(x => x.Status != Status.Passive).ToList();
        
    }
}
