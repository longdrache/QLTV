﻿using LibraryManagerBussiness.VOs;
using LibraryManagerDataAccess.Models;
using LibraryManagerDataAccess.Repositories;
using System.Collections;
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
        public IList GetAllReturn()
        {
            IList returns;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Return> list = uow.ReturnRepository.GetAll().ToList();
                var newReturnList = from @return in list
                                    select new
                                    {
                                        ReturnId = @return.ReturnId,
                                        bookId = @return.BookId,
                                        bookName = @return.Book.Title,
                                        issueId = @return.IssueId,
                                        studentId = @return.StudentId,
                                        studentName = @return.Student.FullName
                                    };


                returns = newReturnList.ToList();
            }

            return returns;
        }
        public IList GetAllReturnByStudentId(int studentId)
        {
            IList returns;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Return> return_list = uow.ReturnRepository.GetAll(re => re.StudentId == studentId).ToList();
                IEnumerable<Issue> issue_list = uow.IssueRepository.GetAll(re => re.StudentId == studentId).ToList();
                var newReturnList = from @return in return_list
                                    join @issue in issue_list
                                    on @return.IssueId equals issue.IssueId
                                    where @issue.StudentId == studentId
                                    select new
                                    {
                                        ReturnId = @return.ReturnId,
                                        BookId = @return.BookId,
                                        BookName = @return.Book.Title,
                                        IssueId = @return.IssueId,
                                        StudentId = @return.StudentId
                                    };


                returns = newReturnList.ToList();
            }

            return returns;
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
