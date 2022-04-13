using DapperAndEntityFrameWorkCourse.Models;
using System.Collections.Generic;

namespace DapperAndEntityFrameWorkCourse.Repositories
{
    public interface IEmployeeRepository
    {
        Employee Find(int id);
        List<Employee> GetAll();
        Employee Add(Employee employee);
        Employee Update(Employee employee); 
        void Remove(int id);
    }
}
