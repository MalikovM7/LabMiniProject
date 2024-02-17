using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMiniProject.Entities
{
    public class Department
    {

        static int count;
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public double MaxSalary { get; set; }

        public List<Employee> Employees { get; set; }

        public Department()
        {
            this.Id = ++count;
        }

    }
}
