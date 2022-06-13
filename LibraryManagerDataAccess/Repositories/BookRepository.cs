using LibraryManagerDataAccess.Context;
using LibraryManagerDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace BloggingAppDataAccess.Repositories
{
    class BookRepository : IRepository<Book>
    {
        LibraryManagerContext m_Context = null;

        public BookRepository(LibraryManagerContext context)
        {
            m_Context = context;
        }

        public IEnumerable<Book> GetAll(System.Linq.Expressions.Expression<Func<Book, bool>> predicate = null)
        {
            return m_Context.Books.Where(predicate);
        }

        public Book Get(System.Linq.Expressions.Expression<Func<Book, bool>> predicate)
        {
            return m_Context.Books.SingleOrDefault(predicate);
        }

        public void Add(Book entity)
        {
            m_Context.Books.Add(entity);
        }

        public void Update(Book entity)
        {
            m_Context.Books.Attach(entity);
            ((IObjectContextAdapter)m_Context).ObjectContext.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
        }

        public void Delete(Book entity)
        {
            m_Context.Books.Remove(entity);
        }

        public int Count()
        {
            return m_Context.Books.Count();
        }
    }
}
