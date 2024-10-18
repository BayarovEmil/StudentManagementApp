using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Repository
{
    public interface IUserRepository<T> where T : class
    {
        T Add(T user);
        T Update(int id,T user);
        bool Delete(int id);
        T GetById(int id);
        List<T> GetAll();
    }
}
