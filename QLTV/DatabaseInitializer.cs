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
            AuthorBUS authorBUS = new AuthorBUS();
            BookBUS bookBUS = new BookBUS();
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
            studentVO.StudentId = 18134025;
            studentVO.DepartmentId = 1;
            studentVO.Sex = true;
            studentVO.State = StudentState.Active;
            studentVO.Birthday = new DateTime(2000, 4, 16);
            studentVO.FullName = "Nguyễn Văn A";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 21234592;
            studentVO.DepartmentId = 2;
            studentVO.Sex = false;
            studentVO.State = StudentState.Reserve;
            studentVO.FullName = "Nguyễn Văn B";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 20339421;
            studentVO.DepartmentId = 3;
            studentVO.Sex = false;
            studentVO.State = StudentState.Graduate;
            studentVO.FullName = "Nguyễn Văn C";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 19234124;
            studentVO.DepartmentId = 4;
            studentVO.Sex = false;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn D";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 19485214;
            studentVO.DepartmentId = 5;
            studentVO.Sex = false;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn E";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 21034245;
            studentVO.DepartmentId = 6;
            studentVO.Sex = true;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn F";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 20194824;
            studentVO.DepartmentId = 7;
            studentVO.Sex = false;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn Bi";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 18239764;
            studentVO.DepartmentId = 8;
            studentVO.Sex = true;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn G";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 19394245;
            studentVO.DepartmentId = 9;
            studentVO.Sex = false;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn H";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 18110482;
            studentVO.DepartmentId = 10;
            studentVO.Sex = true; 
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn I";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 19234213;
            studentVO.DepartmentId = 11;
            studentVO.Sex = false;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn J";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 18425242;
            studentVO.DepartmentId = 12;
            studentVO.Sex = false;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn O";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 20119485;
            studentVO.DepartmentId = 13;
            studentVO.Sex = true;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn K";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 19339204;
            studentVO.DepartmentId = 14;
            studentVO.Sex = true;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn L";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 19329204;
            studentVO.DepartmentId = 14;
            studentVO.Sex = true;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn Lo";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 19334204;
            studentVO.DepartmentId = 14;
            studentVO.Sex = true;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn La";
            studentBUS.GenerateStudent(ref err, studentVO);
            //
            studentVO.StudentId = 19339205;
            studentVO.DepartmentId = 14;
            studentVO.Sex = true;
            studentVO.State = StudentState.Active;
            studentVO.FullName = "Nguyễn Văn Lu";
            studentBUS.GenerateStudent(ref err, studentVO);

            //
            // Add Author
            //
            authorBUS.AddAuthor(ref err, "Harper Lee");
            //
            authorBUS.AddAuthor(ref err, "J.K. Rowling");
            //
            authorBUS.AddAuthor(ref err, "James Patterson");
            //
            authorBUS.AddAuthor(ref err, "Nora Roberts");
            //
            authorBUS.AddAuthor(ref err, "Julia Quinn");
            //
            authorBUS.AddAuthor(ref err, "Clive Cussler");
            //
            authorBUS.AddAuthor(ref err, "Danielle Steel");
            //
            authorBUS.AddAuthor(ref err, "John Grisham");
            //
            authorBUS.AddAuthor(ref err, "J A Jance");
            //
            authorBUS.AddAuthor(ref err, "John Sandford");
            //
            //
            //Add book
            //
            BookVO bookVO = new BookVO();
            bookVO.Title = "To Kill a Mockingbird";
            bookVO.Description = "The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it. 'To Kill A Mockingbird' became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.";
            bookVO.ISBN = "9780060935467";
            bookVO.AuthorId = 1;
            bookVO.Edition = 1;
            bookBUS.AddBook(ref err,bookVO);
            //
            bookVO.Title = "Harry Potter and the Sorcerer's Stone";
            bookVO.Description = "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.";
            bookVO.ISBN = "9781594130007";
            bookVO.AuthorId = 2;
            bookVO.Edition = 1;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Title = "Harry Potter and the Sorcerer's Stone";
            bookVO.Description = "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.";
            bookVO.ISBN = "9781594130007";
            bookVO.AuthorId = 2;
            bookVO.Edition = 1;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Title = "Harry Potter and the Sorcerer's Stone";
            bookVO.Description = "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.";
            bookVO.ISBN = "9781594130007";
            bookVO.AuthorId = 2;
            bookVO.Edition = 1;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Title = "Harry Potter and the Sorcerer's Stone";
            bookVO.Description = "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.";
            bookVO.ISBN = "9781594130007";
            bookVO.AuthorId = 2;
            bookVO.Edition = 1;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Title = "Harry Potter and the Sorcerer's Stone";
            bookVO.Description = "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.";
            bookVO.ISBN = "9781594130007";
            bookVO.AuthorId = 2;
            bookVO.Edition = 1;
            //
            bookVO.Title = "Harry Potter and the Sorcerer's Stone";
            bookVO.Description = "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.";
            bookVO.ISBN = "9781594130007";
            bookVO.AuthorId = 2;
            bookVO.Edition = 1;
            bookBUS.AddBook(ref err, bookVO);
            //
            int i = 0;
            bookVO.Title = "Harry Potter and the Sorcerer's Stone";
            bookVO.Description = "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.";
            bookVO.ISBN = "9781594130007";
            bookVO.AuthorId = 2;
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;
            bookBUS.AddBook(ref err, bookVO);
            //
            bookVO.Edition = ++i;

            bookBUS.AddBook(ref err, bookVO);




        }
    }
}
