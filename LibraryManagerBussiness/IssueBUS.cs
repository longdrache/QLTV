using LibraryManagerBussiness.VOs;
using LibraryManagerDataAccess.Models;
using LibraryManagerDataAccess.Repositories;
using PagedList;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace LibraryManagerBussiness
{
    public partial class IssueBUS
    {
        public IssueBUS()
        {
        }

        public IList<IssueVO> GetAllIssues()
        {
            IList<IssueVO> issues;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Issue> list = uow.IssueRepository.GetAll().ToList();
                IEnumerable<IssueVO> convertIssueList = from issue in list
                                                        select new IssueVO
                                                        {
                                                            IssueId = issue.IssueId,
                                                            StudentId = issue.Student.StudentId,
                                                            StudentName = issue.Student.FullName,
                                                            IssueDate = issue.DateIssue,
                                                            ReturnDate = issue.DateExpirary,
                                                            BookId = issue.Book.BookId,
                                                            BookName = issue.Book.Title
                                                        };


                issues = convertIssueList.ToList();
            }

            return issues;
        }
        public IPagedList<IssueVO> GetSearchAllIssues(string keyword, int pageNumber = 1, int pageSize = 15)
        {
            IList<IssueVO> issues;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Issue> list = uow.IssueRepository.GetAll(iss =>
                  iss.Student.FullName.Contains(keyword) ||
                iss.StudentId.ToString().Contains(keyword) ||
                iss.IssueId.ToString().Contains(keyword) ||
                iss.BookId.ToString().Contains(keyword) ||
                iss.Book.Title.Contains(keyword) ||
                iss.DateExpirary.ToString().Contains(keyword) ||
                iss.DateIssue.ToString().Contains(keyword)
                ).ToList();
                IEnumerable<IssueVO> convertIssueList = from issue in list
                                                        select new IssueVO
                                                        {
                                                            IssueId = issue.IssueId,
                                                            StudentId = issue.Student.StudentId,
                                                            StudentName = issue.Student.FullName,
                                                            IssueDate = issue.DateIssue,
                                                            ReturnDate = issue.DateExpirary,
                                                            BookId = issue.Book.BookId,
                                                            BookName = issue.Book.Title
                                                        };


                issues = convertIssueList.ToList();
            }

            return issues.ToPagedList(pageNumber,pageSize);
        }
        public IList<IssueVO> GetAllIssuesByStudentId(int studentId)
        {
            IList<IssueVO> issues;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Issue> list = uow.IssueRepository.GetAll(issue => issue.StudentId == studentId).ToList();
                IEnumerable<IssueVO> convertIssueList = from issue in list
                                                        select new IssueVO
                                                        {
                                                            IssueId = issue.IssueId,
                                                            StudentId = issue.Student.StudentId,
                                                            StudentName = issue.Student.FullName,
                                                            IssueDate = issue.DateIssue,
                                                            ReturnDate = issue.DateExpirary,
                                                            BookId = issue.Book.BookId,
                                                            BookName = issue.Book.Title
                                                        };


                issues = convertIssueList.ToList();
            }

            return issues;
        }
        public IList GetAllIssuesReturnByStudentId(int studentId)
        {
            IList issues;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Issue> issue_list = uow.IssueRepository.GetAll(issue => issue.StudentId == studentId).ToList();
                IEnumerable<Return> return_list = uow.ReturnRepository.GetAll(re => re.StudentId == studentId).ToList();
                var newIssueList = from @issue in issue_list
                                   join @return in return_list
                                   on @issue.IssueId equals @return.IssueId
                                   where @issue.StudentId == studentId
                                   select new
                                   {
                                       StudentId = issue.Student.StudentId,
                                       StudentName = issue.Student.FullName,
                                       IssueDate = issue.DateIssue,
                                       ReturnDate = issue.DateExpirary,
                                       BookId = issue.Book.BookId,
                                       bookName = issue.Book.Title
                                   };


                issues = newIssueList.ToList();
            }

            return issues;
        }
        public IList GetAllIssuesNotReturnByStudentId(int studentId)
        {
            IList issues;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Issue> issue_list = uow.IssueRepository.GetAll(issue => issue.StudentId == studentId).ToList();
                IEnumerable<Return> return_list = uow.ReturnRepository.GetAll(re => re.StudentId == studentId).ToList();


                IEnumerable<Issue> newIssueList = from @issue in issue_list
                                                  join @return in return_list
                                                  on @issue.IssueId equals @return.IssueId
                                                  where @issue.StudentId == studentId
                                                  select @issue;



                issues = issue_list.Except(newIssueList).Select((issue) => new
                {
                    IssueId = issue.IssueId,
                    StudentId = issue.Student.StudentId,
                    StudentName = issue.Student.FullName,
                    IssueDate = issue.DateIssue,
                    ReturnDate = issue.DateExpirary,
                    BookId = issue.Book.BookId,
                    bookName = issue.Book.Title
                }).ToList();
            }

            return issues;
        }
        public bool AddIssue(ref string err, IssueVO issueVO)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Issue issue = new Issue();
                    issue.BookId = issueVO.BookId;
                    issue.StudentId = issueVO.StudentId;
                    issue.DateIssue = issueVO.IssueDate;
                    issue.DateExpirary = issueVO.ReturnDate;
                    uow.IssueRepository.Add(issue);
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
        public bool RemoveIssue(ref string err, int issueId)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Issue issue = uow.IssueRepository.Get(iss => iss.IssueId == issueId);
                    uow.IssueRepository.Delete(issue);
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
        public bool UpdateIssue(ref string err, IssueVO issueVO)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Issue issue = uow.IssueRepository.Get(iss => iss.IssueId == issueVO.IssueId);
                    if (issue == null) throw new KeyNotFoundException();
                    issue.BookId = issueVO.BookId;
                    issue.StudentId = issueVO.StudentId;
                    uow.IssueRepository.Update(issue);
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
