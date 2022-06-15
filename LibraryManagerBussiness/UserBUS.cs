using LibraryManagerBussiness.Common;
using LibraryManagerBussiness.Exception;
using LibraryManagerBussiness.Models;
using LibraryManagerBussiness.VOs;
using LibraryManagerDataAccess.Models;
using LibraryManagerDataAccess.Repositories;
using PagedList;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

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
                    r = user.Role;
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
                    user.Role = IsAdmin ? Role.Admin : Role.Staff;
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
        public IPagedList<UserVO> GetSearchPageList(string keyword, int pageNumber = 1, int pageSize = 15)
        {
            IList<UserVO> users;
            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<User> list = uow.UserRepository.GetAll(user => user.UserName.Contains(keyword) && user.Role != Role.Admin).ToList();
                IEnumerable<UserVO> userConvert = from user in list
                                                  select new UserVO
                                                  {
                                                      UserName = user.UserName,
                                                      UserId = user.Id,
                                                      Role = user.Role
                                                  };
                users = userConvert.ToList();
            }
            return users.ToPagedList(pageNumber, pageSize);

        }
    }
}
