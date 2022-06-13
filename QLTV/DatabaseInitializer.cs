using LibraryManagerBussiness;
using LibraryManagerBussiness.Models;
using LibraryManagerBussiness.VOs;
using LibraryManagerDataAccess.Context;
using LibraryManagerDataAccess.Models;
using System;
using System.Data.Entity;

namespace QLTV
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<LibraryManagerContext>
    {


        protected override void Seed(LibraryManagerContext context)
        {
            base.Seed(context);
            UserBUS userBUS = new UserBUS();
            string err = null;
            userBUS.GenerateUser(ref err, new RegisterVO() { UserName = "admin", ConfirmPassword = "123456", Password = "123456" }, true);
            userBUS.GenerateUser(ref err, new RegisterVO() { UserName = "user", ConfirmPassword = "123456", Password = "123456" });

            //init department
            DepartmentBUS departmentBUS = new DepartmentBUS();
            departmentBUS.GenerateDepartment(ref err, "Khoa học ứng dụng");
            departmentBUS.GenerateDepartment(ref err, "Đào tạo quốc tế");
            departmentBUS.GenerateDepartment(ref err, "Kinh tế");
            departmentBUS.GenerateDepartment(ref err, "Cơ khí chế tạo máy");
            departmentBUS.GenerateDepartment(ref err, "Công nghệ hóa học và thực phẩm");
            departmentBUS.GenerateDepartment(ref err, "Điện-Điện tử");
            departmentBUS.GenerateDepartment(ref err, "Công nghệ thông tin");
            departmentBUS.GenerateDepartment(ref err, "Cơ khí động lực");
            departmentBUS.GenerateDepartment(ref err, "Xây dựng");
            departmentBUS.GenerateDepartment(ref err, "Chất lượng cao");
            departmentBUS.GenerateDepartment(ref err, "Lý luận chính trị");
            departmentBUS.GenerateDepartment(ref err, "Khoa học ứng dụng");
            departmentBUS.GenerateDepartment(ref err, "Thời trang và du lịch");
            departmentBUS.GenerateDepartment(ref err, "In và truyền thông");
            //init student
            StudentBUS studentBUS = new StudentBUS();
            GenerateStudentVO studentVO = new GenerateStudentVO();
            studentVO.StudentId = 1;
            studentVO.DepartmentId = 1;
            studentVO.Sex = true;
            studentVO.State = StudentState.Active;
            studentVO.Birthday = new DateTime(2000, 4, 16);
            studentVO.FullName = "Nguyễn Văn A";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 2;
            studentVO.DepartmentId = 2;
            studentVO.Sex = false;
            studentVO.State = StudentState.Reserve;
            studentVO.FullName = "Nguyễn Văn B";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 3;
            studentVO.DepartmentId = 3;
            studentVO.Sex = false;
            studentVO.State = StudentState.Graduate;
            studentVO.FullName = "Nguyễn Văn C";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 4;
            studentVO.DepartmentId = 4;
            studentVO.Sex = false;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn D";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 5;
            studentVO.DepartmentId = 5;
            studentVO.Sex = false;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn E";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 6;
            studentVO.DepartmentId = 6;
            studentVO.Sex = true;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn F";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 7;
            studentVO.DepartmentId = 7;
            studentVO.Sex = false;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn B";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 8;
            studentVO.DepartmentId = 8;
            studentVO.Sex = true;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn G";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 9;
            studentVO.DepartmentId = 9;
            studentVO.Sex = false;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn H";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 10;
            studentVO.DepartmentId = 10;
            studentVO.Sex = true; ;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn I";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 11;
            studentVO.DepartmentId = 11;
            studentVO.Sex = false;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn J";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 12;
            studentVO.DepartmentId = 12;
            studentVO.Sex = false;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn O";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 13;
            studentVO.DepartmentId = 13;
            studentVO.Sex = true;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn K";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 14;
            studentVO.DepartmentId = 14;
            studentVO.Sex = true;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn L";
            studentBUS.GenerateStudent(ref err, studentVO);

        }
    }
}
