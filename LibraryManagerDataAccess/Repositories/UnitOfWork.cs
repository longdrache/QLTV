
using LibraryManagerDataAccess.Context;
using LibraryManagerDataAccess.Models;
using System;

namespace LibraryManagerDataAccess.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private LibraryManagerContext m_Context = null;
        private Repository<Author> authorRepository = null;
        private Repository<Book> bookRepository = null;
        private Repository<Department> deparmentRepository = null;
        private Repository<Issue> issueRepository = null;
        private Repository<Return> returnRepository = null;
        private Repository<Student> studentRepository = null;
        private Repository<User> userRepository = null;
        public UnitOfWork()
        {
            m_Context = new LibraryManagerContext();
        }

        public void SaveChanges()
        {

            m_Context.SaveChanges();
        }

        public Repository<Author> AuthorRepository
        {
            get
            {
                if (authorRepository == null)
                {
                    authorRepository = new Repository<Author>(m_Context);
                }
                return authorRepository;
            }
        }

        public Repository<Book> BookRepository
        {
            get
            {
                if (bookRepository == null)
                {
                    bookRepository = new Repository<Book>(m_Context);
                }
                return bookRepository;
            }
        }

        public Repository<Department> DepartmentRepository
        {
            get
            {
                if (deparmentRepository == null)
                {
                    deparmentRepository = new Repository<Department>(m_Context);
                }
                return deparmentRepository;
            }
        }

        public Repository<Issue> IssueRepository
        {
            get
            {
                if (issueRepository == null)
                {
                    issueRepository = new Repository<Issue>(m_Context);
                }
                return issueRepository;
            }
        }

        public Repository<Return> ReturnRepository
        {
            get
            {
                if (returnRepository == null)
                {
                    returnRepository = new Repository<Return>(m_Context);
                }
                return returnRepository;
            }
        }
        public Repository<Student> StudentRepository
        {
            get
            {
                if (studentRepository == null)
                {
                    studentRepository = new Repository<Student>(m_Context);
                }
                return studentRepository;
            }
        }
        public Repository<User> UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new Repository<User>(m_Context);
                }
                return userRepository;
            }
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    m_Context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
