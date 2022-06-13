using LibraryManagerBussiness.VOs;
using LibraryManagerDataAccess.Models;
using LibraryManagerDataAccess.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace LibraryManagerBussiness
{
    public partial class BookBUS
    {
        public BookBUS()
        {
        }
        public IList<BookVO> GetAllBooks()
        {
            IList<BookVO> books;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Book> list = uow.BookRepository.GetAll(b => b.IsDeleted == false).ToList();
                IEnumerable<BookVO> bookConvert = from book in list
                                                  select new BookVO
                                                  {
                                                      BookId = book.BookId,
                                                      Title = book.Title,
                                                      ISBN = book.ISBN,
                                                      AuthorName = book.Author.AuthorName,
                                                      AuthorId = book.AuthorId,
                                                      Description = book.Description,
                                                      Edition = book.Book_Edition
                                                  };


                books = bookConvert.ToList();
            }

            return books;
        }
        public IList<BookVO> GetAllDeletedBooks()
        {
            IList<BookVO> books;

            using (UnitOfWork uow = new UnitOfWork())
            {
                IEnumerable<Book> list = uow.BookRepository.GetAll(b => b.IsDeleted == true).ToList();
                IEnumerable<BookVO> bookConvert = from book in list
                                                  select new BookVO
                                                  {
                                                      BookId = book.BookId,
                                                      Title = book.Title,
                                                      ISBN = book.ISBN,
                                                      AuthorName = book.Author.AuthorName,
                                                      AuthorId = book.AuthorId,
                                                      Description = book.Description,
                                                      Edition = book.Book_Edition
                                                  };


                books = bookConvert.ToList();
            }

            return books;
        }
        public bool AddBook(ref string err, BookVO bookVO)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Book book = new Book();
                    book.ISBN = bookVO.ISBN;
                    book.AuthorId = bookVO.AuthorId;
                    book.Title = bookVO.Title;
                    book.Description = bookVO.Description;
                    book.Book_Edition = bookVO.Edition;
                    uow.BookRepository.Add(book);
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
        public bool RemoveBook(ref string err, int bookId)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Book book = uow.BookRepository.Get(b => b.BookId == bookId);
                    book.IsDeleted = true;
                    uow.BookRepository.Update(book);
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
        public bool UpdateBook(ref string err, BookVO bookVO)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Book book = uow.BookRepository.Get(b => b.BookId == bookVO.BookId);
                    if (book == null) throw new KeyNotFoundException();
                    book.AuthorId = bookVO.AuthorId;
                    book.Description = bookVO.Description;
                    book.Book_Edition = bookVO.Edition;
                    book.Title = bookVO.Title;
                    uow.BookRepository.Update(book);
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
        public bool RecoverBook(ref string err, int bookId)
        {
            bool s;
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    Book book = uow.BookRepository.Get(b => b.BookId == bookId);
                    book.IsDeleted = false;
                    uow.BookRepository.Update(book);
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
