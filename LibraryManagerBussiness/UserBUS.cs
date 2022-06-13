using LibraryManagerBussiness.Common;
using LibraryManagerBussiness.Exception;
using LibraryManagerBussiness.Models;
using LibraryManagerDataAccess.Models;
using LibraryManagerDataAccess.Repositories;
using System.Data.SqlClient;

namespace LibraryManagerBussiness
{
    public partial class UserBUS
    {
        public UserBUS()
        {
        }
        public (bool, Role?) Login(ref string err, string UserName, string Password)
        {
            bool s;
            Role? r;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    var user = uow.UserRepository.Get(u => u.UserName == UserName);

                    if (user == null)
                    {
                        throw new InvalidAccountAccessException("Tên đăng nhập hoặc mật khẩu không hợp lệ!");
                    }
                    string generatedHash = HashComputer.GetPasswordHashAndSalt(Password + user.SecurityStamp);

                    if (generatedHash != user.PasswordHash)
                    {
                        throw new InvalidAccountAccessException("Tên đăng nhập hoặc mật khẩu không hợp lệ!");
                    }
                    r = user.role;
                }

                s = true;
            }
            catch (SqlException)
            {
                err = "Database disconnect!";
                s = false;
                r = null;
            }
            catch (InvalidAccountAccessException ae)
            {
                err = ae.Message;
                s = false;
                r = null;
            }

            return (s, r);
        }
        public bool GenerateUser(ref string err, RegisterVO model, bool IsAdmin = false)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    User cuser = uow.UserRepository.Get(u => u.UserName == model.UserName);
                    if (cuser != null)
                        throw new InvalidAccountRegisterException("Tài khoản đã được đăng ký");
                    if (model.ConfirmPassword != model.Password)
                        throw new InvalidAccountRegisterException("Mật khẩu và xác nhận mật khẩu không khớp");
                    if (model.Password.Length < 6)
                        throw new InvalidAccountRegisterException("Mật khẩu phải lớn hơn 6 ký tự");
                    User user = new User();

                    user.UserName = model.UserName;
                    user.role = IsAdmin ? Role.Admin : Role.Staff;
                    user.SecurityStamp = SaltGenerator.GetSaltString();
                    user.PasswordHash = HashComputer.GetPasswordHashAndSalt(model.Password + user.SecurityStamp);
                    uow.UserRepository.Add(user);
                    uow.SaveChanges();
                }
                s = true;
            }
            catch (SqlException)
            {
                err = "Database disconnect!";
                s = false;
            }
            catch (InvalidAccountRegisterException ae)
            {
                err = ae.Message;
                s = false;
            }
            return s;
        }
    }
}
