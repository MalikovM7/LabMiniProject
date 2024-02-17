using LabMiniProject.Entities;
using LabMiniProject.Helper;
using LabMiniProject.Service;

namespace LabMiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choose;
            bool state = true;
            do
            {

                DepartmentManagmentService service = new DepartmentManagmentService();


                Console.WriteLine("0.Programi bagla");
                Console.WriteLine("1.Department elave et");
                Console.WriteLine("2.Departmente duzelish et");
                Console.WriteLine("3.Departmenti sil");
                Console.WriteLine("4.Butun Departmentleri goster");

                choose = Extension.ReadInt("Siyahdan secin", "Sehv daxil etmisiniz");


                switch (choose)
                {

                    case 0:
                        state = false;

                    break;

                        case 1:
 
                            SubService.AddDepartment();

                    break;
                        case 2:
                            SubService.EditDepartment();
                        break;
                        case 3:
                            SubService.DeleteDepartment();
                        break;
                        case 4:
                            SubService.GetAllDepartments();
                        break;


                        default:
                        break;


                }


            }while (state);





            }
        }
    }

