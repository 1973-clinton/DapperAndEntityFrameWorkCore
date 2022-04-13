using DapperAndEntityFrameWorkCourse.Data;
using DapperAndEntityFrameWorkCourse.Models;
using System.Collections.Generic;
using System.Linq;

namespace DapperAndEntityFrameWorkCourse.Repositories
{
    public class CompanyRepositoryEF : ICompanyRepository
    {

        private readonly ApplicationDbContext _db;

        public CompanyRepositoryEF(ApplicationDbContext db)
        {
            _db = db;
        }
        public Company Add(Company company)
        {
            _db.Add(company);
            _db.SaveChanges();
            return company;
        }

        public Company Find(int id)
        {
            return _db.Companies.FirstOrDefault(u => u.CompanyId == id);
        }

        public List<Company> GetAll()
        {
            return _db.Companies.ToList();
        }

        public void Remove(int id)
        {
            Company company = _db.Companies.FirstOrDefault(u => u.CompanyId == id);
            _db.Companies.Remove(company);
            _db.SaveChanges();
        }

        public Company Update(Company company)
        {
            _db.Update(company);
            _db.SaveChanges();
            return company;
        }
    }
}
