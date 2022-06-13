using LibraryManagerDataAccess.Models;
using LibraryManagerDataAccess.Repositories;
using System.Data.SqlClient;

namespace LibraryManagerBussiness
{
    public partial class DepartmentBUS
    {
        public DepartmentBUS()
        {
        }
        public bool GenerateDepartment(ref string err, string departmentName)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Department department = new Department();

                    department.DepartmentName = departmentName;
                    uow.DepartmentRepository.Add(department);
                    uow.SaveChanges();
                }
                s = true;
            }
            catch (SqlException)
            {
                err = "Database disconnect!";
                s = false;
            }
            return s;
        }
    }
}
