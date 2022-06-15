using LibraryManagerBussiness.VOs;
using LibraryManagerDataAccess.Models;
using LibraryManagerDataAccess.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace LibraryManagerBussiness
{
    public partial class AuthorBUS
    {
        public AuthorBUS()
        {
        }

        public IList<AuthorVO> GetAllAuthors()
        {
            IList<AuthorVO> authors;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Author> list = uow.AuthorRepository.GetAll(a => a.IsDeleted == false).ToList();
                IEnumerable<AuthorVO> bookConvert = from author in list
                                                    select new AuthorVO
                                                    {
                                                        AuthorId = author.AuthorId,
                                                        AuthorName = author.AuthorName,

                                                    };


                authors = bookConvert.ToList();
            }

            return authors;
        }
        public IList<AuthorVO> GetAllDeletedAuthors()
        {
            IList<AuthorVO> authors;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Author> list = uow.AuthorRepository.GetAll(a => a.IsDeleted == true).ToList();
                IEnumerable<AuthorVO> bookConvert = from author in list
                                                    select new AuthorVO
                                                    {
                                                        AuthorId = author.AuthorId,
                                                        AuthorName = author.AuthorName,

                                                    };


                authors = bookConvert.ToList();
            }

            return authors;
        }
        public bool AddAuthor(ref string err, string authorName)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Author author = new Author();
                    author.AuthorName = authorName;
                    uow.AuthorRepository.Add(author);
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
        public bool RemoveAuthor(ref string err, int authorId)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Author author = uow.AuthorRepository.Get(au => au.AuthorId == authorId);
                    author.IsDeleted = true;
                    uow.AuthorRepository.Update(author);
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
        public bool UpdateAuthor(ref string err, AuthorVO authorVO)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Author author = uow.AuthorRepository.Get(au => au.AuthorId == authorVO.AuthorId);
                    author.AuthorName = authorVO.AuthorName;
                    uow.AuthorRepository.Update(author);
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
        public bool RecoverAuthor(ref string err, int authorId)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Author author = uow.AuthorRepository.Get(au => au.AuthorId == authorId);
                    author.IsDeleted = false;
                    uow.AuthorRepository.Update(author);
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
