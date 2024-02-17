using LabMiniProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMiniProject.Entities
{
    public class Employee
    {

        static int count;
        public int Id { get; private set; }
        public string FullName { get; set; }

        public int Salary { get; set; }

        public Position Position { get; set; }

        public DateTime CreateDate { get; set; }

        public Employee()
        {
            this.Id = ++count;
        }

    }
}
