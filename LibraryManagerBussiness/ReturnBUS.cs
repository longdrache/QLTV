using LibraryManagerBussiness.VOs;
using LibraryManagerDataAccess.Models;
using LibraryManagerDataAccess.Repositories;
using PagedList;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace LibraryManagerBussiness
{
    public partial class ReturnBUS
    {
        public ReturnBUS()
        {
        }
        public IPagedList<ReturnVO> GetSearchAllReturn(string keyword,int pageNumber = 1, int pageSize = 15)
        {
            IList<ReturnVO> returns;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Return> list = uow.ReturnRepository.GetAll(re =>
                re.Student.FullName.Contains(keyword) ||
                re.StudentId.ToString().Contains(keyword) ||
                re.IssueId.ToString().Contains(keyword) ||
                re.BookId.ToString().Contains(keyword) ||
                re.Book.Title.Contains(keyword) ||
                re.ReturnDate.ToString().Contains(keyword)
                ).ToList();
                IEnumerable<ReturnVO> newReturnList = from @return in list
                                                      select new ReturnVO
                                                      {
                                                          ReturnId = @return.ReturnId,
                                                          BookId = @return.BookId,
                                                          BookName = @return.Book.Title,
                                                          StudentName = @return.Student.FullName,
                                                          StudentId = @return.StudentId,
                                                          ReturnDate = @return.ReturnDate,
                                                          IssueId = @return.IssueId,
                                                      };


                returns = newReturnList.ToList();
            }

            return returns.ToPagedList(pageNumber, pageSize);
        }
        public IPagedList<ReturnVO> GetAllReturnByStudentId(int studentId, int pageNumber = 1, int pageSize = 15)
        {
            IList<ReturnVO> returns;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Return> return_list = uow.ReturnRepository.GetAll(re => re.StudentId == studentId).ToList();
                IEnumerable<Issue> issue_list = uow.IssueRepository.GetAll(re => re.StudentId == studentId).ToList();
                IEnumerable<ReturnVO> newReturnList = from @return in return_list
                                                      join @issue in issue_list
                                                      on @return.IssueId equals issue.IssueId
                                                      where @issue.StudentId == studentId
                                                      select new ReturnVO
                                                      {
                                                          ReturnId = @return.ReturnId,
                                                          BookId = @return.BookId,
                                                          BookName = @return.Book.Title,
                                                          StudentName = @return.Student.FullName,
                                                          StudentId = @return.StudentId,
                                                          ReturnDate = @return.ReturnDate,
                                                          IssueId = @return.IssueId,
                                                      };


                returns = newReturnList.ToList();
            }

            return returns.ToPagedList(pageNumber,pageSize);
        }
        public bool AddReturnBook(ref string err, ReturnVO returnVO)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Return returnO = new Return();
                    returnO.IssueId = returnVO.IssueId;
                    returnO.StudentId = returnVO.StudentId;
                    returnO.BookId = returnVO.BookId;
                    returnO.ReturnDate = returnVO.ReturnDate;
                    uow.ReturnRepository.Add(returnO);
                    uow.SaveChanges();
                }
                s = true;
            }
            catch (SqlException ex)
            {
                err = ex.Message;
                s = false;
            }

            return s;
        }

    }
}
