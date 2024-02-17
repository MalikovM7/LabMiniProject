using LabMiniProject.Entities;
using LabMiniProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LabMiniProject.Service
{
    public class DepartmentManagmentService : IDepartmentManagementService
    {

        private List<Employee> employees;
        private List<Department> departments;

        public DepartmentManagmentService()
        {
            employees = new List<Employee>();
            departments = new List<Department>();
        }
        public void AddDepartement(string name, int capacity, double maxSalary)
        {
            if (departments.Any(d => d.Name == name))
            {

                Console.WriteLine("Bu adli departament artiq var");

                return;

            }
            
                Department department = new Department();

                department.Name = name;
                department.Capacity = capacity;
                department.MaxSalary = maxSalary;

                departments.Add(department);

            


           
        }

        public void DeleteDepartement(int id)
        {

            Department departmentToDelete = departments.Find(dep => dep.Id == id);

            
            if (departmentToDelete != null)
            {
               
                departments.Remove(departmentToDelete);
                Console.WriteLine($"Department with Id {id} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Department with Id {id} not found.");
            }



        }

        public void EditDepartement(int id, string name, int capacity, double maxSalary)
        {
            Department departmentToEdit = departments.Find(d => d.Id == id);

            if (departmentToEdit != null)
            {
                
                departmentToEdit.Name = name;
                departmentToEdit.Capacity = capacity;
                departmentToEdit.MaxSalary = maxSalary;

                Console.WriteLine($"Department {id} edited successfully. New name: {name}");
            }
            else
            {
                Console.WriteLine($"Department with Id {id} not found.");
            }


        }

        public void GetAllDepartements()
        {
            Console.WriteLine("All Departments:");
            foreach (var department in departments)
            {
                Console.WriteLine($"Id: {department.Id}, Name: {department.Name}");
            }

           
        }
    }
    }

