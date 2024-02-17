using LabMiniProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMiniProject.Interface
{
    public interface IDepartmentManagementService
    {

        public void AddDepartement(string name, int capacity, double maxSalary);
        public void EditDepartement(int id, string name, int capacity, double maxSalary);
        public void DeleteDepartement(int id);

        public void GetAllDepartements();



    }
}
