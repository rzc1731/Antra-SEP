// See https://aka.ms/new-console-template for more information
using System;

namespace GenericRepository
{
    public class GenericRepository
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }

    public class GenericRepository<T> : IRepository<T> where T : class
    {
        List<T> db = new List<T>();
        public GenericRepository()
        {
        }

        public IEnumerable<T> GetAll()
        {
            return db;
        }

        public T GetById(int id)
        {
            return db[id];
        }

        public void Add(T entity)
        {
            db.Add(entity);
        }

        public void Remove(T entity)
        {
            db.Remove(entity);
        }

        public void Save()
        {
            
        }
    }
}
