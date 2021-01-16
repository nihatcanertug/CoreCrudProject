using CoreCrudProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrudProject.DataLayer.Repositories.Interface
{
    public interface IAppUserRepository
    {
        AppUser GetById(int id);

        void Create(AppUser appUser);
        void Edit(AppUser appUser);
        void Delete(int id);

        List<AppUser> GetUser();
    }
}
