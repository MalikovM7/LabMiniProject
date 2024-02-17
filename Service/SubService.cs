using LabMiniProject.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace LabMiniProject.Service
{
    public class SubService
    {
        private static DepartmentManagmentService  departmentService = new DepartmentManagmentService();


        public static void AddDepartment()
        {
            string name = Extension.ReadString("Departmentin adini daxil edin: ", "Sehv daxil etdiniz");
            int capacity = Extension.ReadInt("Departmentin maksimal ishci sayini daxil edin: ", "Sehv daxil etdiniz");
            double maxSalary = Extension.ReadDouble("Maksimum maash limitini daxil edin:", "Sehv daxil etdiniz");

            departmentService.AddDepartement(name, capacity,maxSalary);
        }


        public static void EditDepartment()
        {
            int id = Extension.ReadInt("Departmentin Id-sini daxil edin: ", "Sehv daxil etmisiz!");
            string name = Extension.ReadString("Departmentin yeni adini daxil edin: ", "Sehv daxil etdiniz");
            int capacity = Extension.ReadInt("Departmentin yeni maksimal ishci sayini daxil edin: ", "Sehv daxil etdiniz");
            double maxSalary = Extension.ReadDouble("Yeni maksimum maash limitini daxil edin:", "Sehv daxil etdiniz");

            departmentService.EditDepartement(id, name, capacity,maxSalary);
        }


        public static void DeleteDepartment()
        {
            int id = Extension.ReadInt("Departmentin Id-sini daxil edin: ", "Sehv daxil etmisiz!");
            departmentService.DeleteDepartement(id);

        }

        public static void GetAllDepartments()
        {
            departmentService.GetAllDepartements();
        }

    }
}
